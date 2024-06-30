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
using System.IO;


namespace EZMath
{
    public partial class AddExForm : Form
    {
        Image i;
        Bitmap b;
        private string path, finalAnsPath;
        private TeachersBL teacher;
        SubjectsBL sub;
        ManagerBL manager;
        public AddExForm(ManagerBL Manager)
        {
            InitializeComponent();
            manager = Manager;
        }

        /// <summary>
        /// Gives the option to browse a picture of exercise in your computer and preview how it will look on the picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BrowseFolder_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult re = ofd.ShowDialog();
            if (re == DialogResult.OK)
            {
                path = ofd.FileName;
                i = Image.FromFile(ofd.FileName);
                b = (Bitmap)i;
                exPreview.Image = b;
            }
        }

       /// <summary>
       /// Inserts the Difficulty's and the Subjects into a ComboBox when the form loads
       /// </summary>
       /// <param name="sender"></param>
       /// <param name="e"></param>
        private void AddExForm_Load(object sender, EventArgs e)
        {
            sub = new SubjectsBL();
            teacher = LoginForm.teacher;
            DiffList.DataSource = Config.DiffList;
            SubjectList.DataSource = manager.GetAllSubjectNames();
        }

        private void AddExButton_Click(object sender, EventArgs e)
        {
            string subject = SubjectList.Text;
            int subID = manager.GetSubByText(subject);
            int diff = int.Parse(DiffList.Text);
            string answerRes = FinalAns.Text;


            if (path != null && finalAnsPath != null)
            {
                string[] temp = path.Split('\\');
                string WinformsPath = "Ex/";  //set the new path for windows forms app
                string AspxPath = "../../../../EZMathStudents/EZMathStudents/Ex/"; // set the new path for aspx path
                string picName = temp[temp.Length - 1]; //get the file name
                string name = picName.Split('.')[0]; //seperate filename to name and format
                string format = picName.Split('.')[1];
                string ext = ""; //extension
                int i = 1; //counter
                
                while (File.Exists(WinformsPath + name + ext + "." + format) || File.Exists(AspxPath + name + ext + "." + format)) //while one of the assembled paths already exists 
                {
                    ext = "(" + i + ")"; //edit the extension
                    i++; //incremeant the counter
                  
                }
                
                File.Copy(path, WinformsPath + name + ext + "." + format); //copy the selected file to a new winforms path
                File.Copy(path, AspxPath + name + ext + "." + format); //copy the selected file to a new aspx path

                temp = finalAnsPath.Split('\\');
                picName = temp[temp.Length - 1]; //get the file name
                string solName = picName.Split('.')[0];
                format = picName.Split('.')[1];
                ext = ""; //extension
                i = 1; //counter
                
                while (File.Exists(WinformsPath + solName + ext + "_sol." + format) || File.Exists(AspxPath + solName + ext + "_sol." + format)) //while the assembled path already exists 
                {
                    ext = "(" + i + ")"; //edit the extension
                    i++; //incremeant the counter
                }
                File.Copy(finalAnsPath, WinformsPath + solName + ext + "_sol." + format); //copy the selected file to a new path
                File.Copy(finalAnsPath, AspxPath + solName + ext + "_sol." + format); //copy the selected file to a new path
                int r = teacher.AddExercise(WinformsPath + name + ext + "." + format, subID, diff, WinformsPath + solName + ext + "_sol." + format); //add the exercise to the DB
                if (r != 0)
                {
                    MessageBox.Show("תרגיל נוסף בהצלחה");
                }
            }
            else
            {
                MessageBox.Show("אנא צרף תרגיל ותשובות סופיות בפורמט  png , jpg","שגיאה!", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign | MessageBoxOptions.RtlReading); // Sets messagebox caption and design 
            }         
        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            TeacherMainForm f1 = new TeacherMainForm(manager);
            f1.Show();
            this.Hide();
        }

        private void BrowseFolderFinalAns_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult re = ofd.ShowDialog();
            if (re == DialogResult.OK)
            {
                finalAnsPath = ofd.FileName;
                i = Image.FromFile(ofd.FileName);
                b = (Bitmap)i;
                FinalAns.Image = b;
            }
        }
    }
}
