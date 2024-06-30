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
    public partial class TeacherMainForm : Form
    {
        private TeachersBL teacher;
        private ManagerBL manager;
        public TeacherMainForm(ManagerBL Manager)
        {
            InitializeComponent();
            manager = Manager;
        }
        /// <summary>
        /// a label text will appear with hello "teachername" when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TeacherMainForm_Load(object sender, EventArgs e)
        {
            teacher = LoginForm.teacher;
            helloLabel.Text = "שלום " + teacher.GetTeacherName(); 
        }

        private void createExam_Click(object sender, EventArgs e)
        {
            CreateExam f2 = new CreateExam(manager);
            f2.Show();
            this.Hide();
        }

        private void AddEx_Click(object sender, EventArgs e)
        {
            AddExForm f3 = new AddExForm(manager);
            f3.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InsertGrades f4 = new InsertGrades(manager);
            f4.Show();
            this.Hide();
        }

        private void StatsBtn_Click(object sender, EventArgs e)
        {
            StatsForm f5 = new StatsForm(manager);
            f5.Show();
            this.Hide();
        }

        private void ViewExams_Click(object sender, EventArgs e)
        {
            ExamViewForm f6 = new ExamViewForm(manager);
            f6.Show();
            this.Hide();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            LoginForm f1 = new LoginForm();
            f1.Show();
            this.Close();
        }
    }
}
