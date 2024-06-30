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
    public partial class ExamView : Form
    {
        private TeachersBL teacher;
        private ManagerBL manager = new ManagerBL();       
        private int currentChosenExam;

        public ExamView(int examid)
        {         
            InitializeComponent();
            this.currentChosenExam = examid;
        }

        private void ExamView_Load(object sender, EventArgs e)
        {
            teacher = LoginForm.teacher;
            DataTable Exam = manager.GetExamById(this.currentChosenExam); // gets the chosen exam id
            ExamNameLabel.Text = Exam.Rows[0]["ExamName"].ToString(); // inserts the exam name into the label
            ExamDateLabel.Text = Exam.Rows[0]["ExamDate"].ToString().Replace(':','/'); // Insert's the date exam and replaces all : with /
            ExamNotes.Text = "הוראות המבחן: " + Exam.Rows[0]["ExamRules"].ToString(); // Insert's the Exam rules into a textbox
            PictureBox currentEx; // exercise path picturebox
            string path; // ex path
            List<ExamBL> teacherExams = teacher.GetTeacherExams(); //Get teachers exam list
            DataTable dt = manager.GetExamExercises(currentChosenExam); //Get the chosen exam exercises paths
            for (int i = 0; i < dt.Rows.Count; i++) // for each exercise create a picturebox with the ex path
            {
                path = dt.Rows[i]["ExercisePath"].ToString();
                currentEx = new PictureBox();
                currentEx.SizeMode = PictureBoxSizeMode.StretchImage; // picturebox sizeMode
                currentEx.Size = new System.Drawing.Size(790,600); // exercise preview size
                currentEx.ImageLocation = path; // Insert's the picture box the exercise path
                ShowExamPanel.Controls.Add(currentEx); // Insert's the FlowLayOutPanel all the pictureboxes with the Exercise paths
            }
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            ExamViewForm f6 = new ExamViewForm(manager);
            f6.Show();
            this.Hide();
        }
    }
    }

