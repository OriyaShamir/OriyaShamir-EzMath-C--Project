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
    public partial class ExamViewForm : Form
    {
        public ExamViewForm(ManagerBL Manager)
        {
            InitializeComponent();
            manager = Manager;
        }
        private ManagerBL manager;
        private TeachersBL teacher;
        private ExamBL currentExam;
        private void ExamViewForm_Load(object sender, EventArgs e)
        {
            teacher = LoginForm.teacher;
            List<ExamBL> teacherExams = teacher.GetTeacherExams(); //Get the teacher exams
            List<string> examNames = new List<string>(); // Convert the exams list to exam *Names* list
            foreach (ExamBL exam in teacherExams)
            {
                examNames.Add(exam.GetexamName());
            }
            examList.DataSource = examNames; //Update the related combobox          
        }

        private void ShowExamBtn_Click(object sender, EventArgs e)
        {
            int id = manager.GetExamID(examList.Text); // gets the id of the exam chosen at the exam's comboBox 
            ExamView f7 = new ExamView(id);
            f7.Show();
            this.Hide();
            string examName = examList.Text; //Get the chosen exam name
            currentExam = new ExamBL(examName); // Create new exam according to the exam name
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            TeacherMainForm f1 = new TeacherMainForm(manager);
            f1.Show();
            this.Hide();
        }
        //private string HtmlCreate(ExamBL currentExam)
        //{
        //    List<string> t = new List<string>();
        //    t.Add("<html>");
        //    t.Add("<head>");
        //    t.Add("<title>" + currentExam.GetexamName() + "</title>");
        //    t.Add("</head>");
        //    t.Add("<body>");
        //    t.Add("<h1> " + currentExam.GetexamName() + "</h1>");
        //    t.Add("<h3> מורה: " + teacher.GetTeacherName() + " </h3>");
        //    t.Add("<h3> תאריך:" + currentExam.GetExamDate() + "</h3>");

        //}
    }
}
