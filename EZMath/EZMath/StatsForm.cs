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
    public partial class StatsForm : Form
    {
        private ManagerBL manager;
        public StatsForm(ManagerBL Manager)
        {
            InitializeComponent();
            manager = Manager;
        }

        private TeachersBL teacher;
        private ExamBL currentExam;
        private ExercisesBL currentEx;
        private TeacherExStats stats;

        private void StatsForm_Load(object sender, EventArgs e)
        {
            teacher = LoginForm.teacher; //Get the current working teacher
            List<ExamBL> teacherExams = teacher.GetTeacherExams(); //Get the teacher exams
            List<string> examNames = new List<string>(); // Convert the exams list to exam *Names* list
            foreach (ExamBL exam in teacherExams)
            {
                examNames.Add(exam.GetexamName());
            }
            examList.DataSource = examNames; //Update the related combobox
            examList_SelectedIndexChanged(sender, e); //calling the function 
            ClassCombobox.DataSource = teacher.GetClassNames(); //Set teacher classes combobox
        }
        private void examList_SelectedIndexChanged(object sender, EventArgs e)
        {
            string examName = examList.Text; //Get the chosen exam name
            currentExam = new ExamBL(examName); // Create new exam according to the exam name
            List<string> ex = new List<string>(); 
            int i = 1;
            foreach (ExercisesBL exer in currentExam.GetExercises()) //Convert the exam exercises list to exam *Numbers* exercise list
            {
                ex.Add(i.ToString());
                i++;
            }
            QuestionList.DataSource = ex; //Update the related combobox
        }

        private void QuestionList_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentClass = teacher.GetClassIdByName(ClassCombobox.Text);
            currentEx = currentExam.GetExercises()[int.Parse(QuestionList.Text) - 1]; //Get the chosen exercise
            stats = teacher.GetStatsOfEx(currentExam.GetExamID(), currentEx.GetExid(), currentClass); // Get the exercise and exam stats
            ExamAvg.Text = String.Format("{0:0.00}", stats.GetExamAvg()); //Update the field
            ExAvg.Text = String.Format("{0:0.00}", stats.GetGeneralStats()); //Update the field
            ExExamAvg.Text = String.Format("{0:0.00}", stats.GetExamStats()); //Update the field
            ExTeacherAvg.Text = String.Format("{0:0.00}", stats.GetTeacherlStats()); //Update the field
            ClassStat.Text = String.Format("{0:0.00}", stats.GetClassStats());
            Bitmap ex = new Bitmap(currentEx.GetExercisePath()); //Create new image by the exercise path
            exPreview.Image = ex; //Update the picture box
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            TeacherMainForm f1 = new TeacherMainForm(manager);
            f1.Show();
            this.Hide();
        }

        private void ClassCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (currentExam != null)
            {
                int currentClass = teacher.GetClassIdByName(ClassCombobox.Text);
                if (QuestionList.Text != "")
                {
                    currentEx = currentExam.GetExercises()[int.Parse(QuestionList.Text) - 1]; //Get the chosen exercise
                    stats = teacher.GetStatsOfEx(currentExam.GetExamID(), currentEx.GetExid(), currentClass); // Get the exercise and exam stats
                    ExamAvg.Text = String.Format("{0:0.00}", stats.GetExamAvg()); //Update the field
                    ExAvg.Text = String.Format("{0:0.00}", stats.GetGeneralStats()); //Update the field
                    ExExamAvg.Text = String.Format("{0:0.00}", stats.GetExamStats()); //Update the field
                    ExTeacherAvg.Text = String.Format("{0:0.00}", stats.GetTeacherlStats()); //Update the field
                    ClassStat.Text = String.Format("{0:0.00}", stats.GetClassStats());
                    Bitmap ex = new Bitmap(currentEx.GetExercisePath()); //Create new image by the exercise path
                    exPreview.Image = ex; //Update the picture box
                }
            }
        }

        private void Recommendations_Click(object sender, EventArgs e)
        {
            string recommand = " היי " + teacher.GetTeacherName()+"\n";
            if (this.stats != null) // if there is any satistic, give recommandations by the rules (readme)
            {
                if (stats.GetExamStats() < 50)
                {
                    recommand += string.Format("אולי תרצה לחזור על החומר או להחליף את תרגיל {0} אחוזי ההצלחה נמוכים  !\n", QuestionList.Text);
                }
                if (stats.GetExamAvg() < 56)
                {
                    recommand += "אולי תרצה לתת לכיתה פקטור ולבדוק את רמת הקושי של המבחן  !\n";
                }
                if (stats.GetTeacherlStats() < stats.GetGeneralStats() - 10)
                {
                    recommand += String.Format("אולי תרצה לבצע חזרה על החומר של תרגיל {0} זה בכל הכיתות  !\n", QuestionList.Text);
                }
                if (stats.GetClassStats() < stats.GetTeacherlStats() - 10)
                {
                    recommand += String.Format("אולי תרצה לבצע חזרה על החומר של תרגיל {0} בכיתה זו  !\n", QuestionList.Text);
                }
                if (stats.GetExamStats() > 95)
                {
                    recommand += String.Format("אולי תרצה לשקול מחדש האם תרגיל {0} קל מדי  !\n", QuestionList.Text);
                }
                if (stats.GetExamAvg() > 95)
                {
                    recommand += String.Format("אולי תרצה לשקול את רמת הקושי של המבחן  !\n");
                }
                if (stats.GetTeacherlStats() > stats.GetGeneralStats() + 10)
                {
                    recommand += String.Format(" עבודה מצוינת בתרגיל {0} מעולה!  ! \n", QuestionList.Text);
                }
                if (recommand == " היי " + teacher.GetTeacherName() + "\n") // if there isn't any recommandations it will show this message
                {
                    recommand += String.Format("אין המלצות לנתונים אלו, כל הכבוד  !\n", QuestionList.Text);
                }
            }
            MessageBox.Show(this, recommand, "המלצות", MessageBoxButtons.OK,
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading); // Sets messagebox caption and design
        }

        private void RecommandHelp_Click(object sender, EventArgs e)
        {
            string recommand = " היי " + teacher.GetTeacherName() + "\n";
            recommand += " כאשר ממוצע התרגיל במבחן קטן מ50, תתקבל המלצה להחליף את התרגיל או לחזור על החומר לחזור על חומר התרגיל\n";
            recommand += "אם ממוצע המבחן קטן מ56, תתקבל המלצה להביא פקטור לכיתה או לבדוק את רמת הקושי של המבחן \n";
            recommand += "אם ממוצע התרגיל אצל המורה הספציפי המחובר נמוך ממוצע התרגיל בכללי במערכת תתקבל המלצה לחזור על חומר של תרגיל זה אצל כל הכיתות\n";
            recommand += "אם ממוצע התרגיל בכיתה הספציפית שנבחרה קטן מממוצע התרגיל אצל המורה תתקבל המלצה למורה לחזור על חומר תרגיל זה אצל הכיתה הספציפית שנבחרה\n";
            recommand += "אם ממוצע התרגיל במבחן הוא מעל 95 תתקבל המלצה לחשוב האם תרגיל זה קל מידי\n";
            recommand += "אם ממוצע המבחן מעל 95 תתקבל המלצה לחשוב האם המבחן עצמו קל מידי\n";
            recommand += "אם ממוצע התרגיל אצל המורה גבוה ממוצע התרגיל בכללי במערכת אז תקבל הודעת כל הכבוד! :)\n";
            MessageBox.Show(this, recommand, "לפי מה אני מקבל המלצות?", MessageBoxButtons.OK,
            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading); // Sets messagebox caption and design
        }
    }
}
