using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL_Project;

namespace EZMath
{
    public partial class InsertGrades : Form
    {
        private TeachersBL teacher;
        private ClassBL cl;
        private ExamBL currentExam;
        private ManagerBL manager;
        public InsertGrades(ManagerBL Manager)
        {
            InitializeComponent();
            manager = Manager;

        }

        
        private void SubjectList_SelectedIndexChanged(object sender, EventArgs e)
        {           
            int classId = ClassBL.GetClassId(ClassList.Text); //Get the chosen class
            cl = new ClassBL(classId, teacher.GetTeacherId()); //Create the chosen class
            string[] row; 
            Students.Rows.Clear(); //Empty the DataGridView
            foreach (StudentsBL st in cl.GetStudentsInClass()) // For each student, add a row in the DataGridView
            {
                row = new string[] { st.GetStudentID().ToString(), st.GetName() }; //Row contains studentId, name, grade and update button
                Students.Rows.Add(row);
            }
        }

        private void InsertGrades_Load(object sender, EventArgs e)
        {           
           teacher = LoginForm.teacher;
            //Create DataGridView
            Students.ColumnCount = 2;
            Students.Columns[0].Name = "StudentID";
            Students.Columns[0].HeaderText = "מזהה תלמיד";
            Students.Columns[1].Name = "StudentName";
            Students.Columns[1].HeaderText = "שם תלמיד:";
            DataGridViewTextBoxColumn grades = new DataGridViewTextBoxColumn();
            Students.Columns.Add(grades);
            grades.HeaderText = "ציון";
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            Students.Columns.Add(btn);
            btn.HeaderText = "עדכן";
            btn.Text = "עדכן";
            btn.UseColumnTextForButtonValue = true;
            ClassList.DataSource = teacher.GetClassNames(); //Update the class combobox
            List<ExamBL> teacherExams = teacher.GetTeacherExams(); //Get teachers exam list
            List<string> examNames = new List<string>(); // Convert exam list to exam *Name* list
            foreach(ExamBL exam in teacherExams)
            {
                examNames.Add(exam.GetexamName());
            }
            examList.DataSource = examNames; //Update the reated combobox
            Students.Update(); // Update the DataGridView
        }

        private void Students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3) //If clicked on the "Update" button
            {
                int grade;
                if (int.TryParse(Students.Rows[e.RowIndex].Cells[2].Value.ToString(), out grade)) //Get the grade value
                {

                    if (grade > 100 || grade < 0) //Check if grade value is valid (between 0-100)
                    {
                        MessageBox.Show("אנא הכנס מספר בין 0 ל-100");
                    }
                    else
                    {
                        StudentsBL student;
                        int studentId = int.Parse(Students.Rows[e.RowIndex].Cells[0].Value.ToString()); //Get the updated student
                        student = new StudentsBL(studentId);
                        int examId = currentExam.GetExamID(); //Get the current exam id
                        int exId = currentExam.GetExercises()[int.Parse(QuestionList.Text) - 1].GetExid(); //Get the current exercise id
                        int r = teacher.InsertGradeforStudentInEx(student, examId ,exId , grade); //Update\Insert the grade
                        if (r != 0)
                        {
                            MessageBox.Show("הציון עודכן בהצלחה");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("אנא הכנס מספר בין 0 ל-100");
                }
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            TeacherMainForm f1 = new TeacherMainForm(manager);
            f1.Show();
            this.Hide();
        }

        private void examList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string examName = examList.Text;
            currentExam = new ExamBL(examName); //Get the chosen exam name
            List<string> ex = new List<string>(); // Get the exercise list of the exam
            int i = 1;
            foreach(ExercisesBL exer in currentExam.GetExercises()) //Convert the exercise list to numberd list
            {
                ex.Add(i.ToString());
                i++;
            }
            QuestionList.DataSource = ex; //Update the combobox
        }

        private void QuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int studentId, examId, exId, grade;
            StudentsBL student;
            examId = currentExam.GetExamID(); //Get the chosen exam
            exId = currentExam.GetExercises()[int.Parse(QuestionList.Text) - 1].GetExid(); // Get the chosen exercise
            for (int i = 0; i < Students.Rows.Count; i++)
            {
                studentId = int.Parse(Students.Rows[i].Cells[0].Value.ToString()); //get the updated student
                student = new StudentsBL(studentId);
                grade = teacher.GetGradeOfStudentInEx(student, examId, exId); //get the current grade of the student
                if (grade != -1)
                {
                    Students.Rows[i].Cells[2].Value = grade;
                }
                else
                {
                    Students.Rows[i].Cells[2].Value = 0;
                }
            }
        }

        /// <summary>
        /// Updates all the grades that has been inserted together 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateAll_Click(object sender, EventArgs e)
        {

            int grade;
            int r = 1;
            for (int i = 0; i < Students.Rows.Count; i++)
            {
                if (int.TryParse(Students.Rows[i].Cells[2].Value.ToString(), out grade))
                {
                    if (grade > 100 || grade < 0)
                    {
                        MessageBox.Show("אנא הכנס מספר בין 0 ל-100");
                    }
                    else
                    {
                        StudentsBL student;
                        int studentId = int.Parse(Students.Rows[i].Cells[0].Value.ToString());
                        student = new StudentsBL(studentId);
                        int examId = currentExam.GetExamID();
                        int exId = currentExam.GetExercises()[int.Parse(QuestionList.Text) - 1].GetExid();
                        r *= teacher.InsertGradeforStudentInEx(student, examId, exId, grade);
                    }
                }
                else
                {
                    r = 0;
                }
            }
            if (r != 0)
            {
                MessageBox.Show("הציונים עודכנו בהצלחה");
            }
            else
            {
                MessageBox.Show("אנא הכנס מספר בין 0 ל-100");
            }
        }
    }
}
