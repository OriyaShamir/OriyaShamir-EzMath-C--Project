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
    public partial class CreateExam : Form
    {
        private TeachersBL teacher;
        private List<ExercisesBL> exam;
        private List<SubjectsBL> subjectsList;
        private List<ExercisesBL> exList;
        private int currentEx;
        private SubjectsBL sub;
        private ManagerBL manager;
        private bool showAll;

        public CreateExam(ManagerBL Manager)
        {
            manager = Manager;
            InitializeComponent();
            subjectsList = manager.GetAllSubjects(); // inserts the subject's combo box all the subjects   
        }

        /// <summary>
        /// Insert's the exercises of the chosen subject at the combobox to the picturebox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void subjects_SelectedIndexChanged(object sender, EventArgs e)
        {
           /* foreach (SubjectsBL sub in subjectsList)
            {
                if (sub.GetsubjectText() == SubjectCombo.Text)
                {
                    exList = sub.GetSubExercises();
                }
            }*/
            currentEx = 0;
            int sub = manager.GetSubjectID(SubjectCombo.Text); // gets the id of the selected subject at the combo box
            if ((exList = manager.GetOrderedByStatsExBySub(sub)) == null) // sort's the exercises In order by best satistics
            {
                currentLoc.Text = " 0/ 0";
                exPreview.Image = null;
                leftEx.Enabled = false;
                rightEx.Enabled = false;
                return;
            }
            leftEx.Enabled = true;
            rightEx.Enabled = true;
            currentEx = 0;
            if (exam.Contains(exList[currentEx])) // if the exam already contains the showen ex
            {
                addEx.Text = "הסר תרגיל";
                addEx.ForeColor = Color.Red;
            }
            else
            {
                addEx.Text = "הוסף תרגיל";
                addEx.ForeColor = Color.Black;
            }

            Bitmap ex = new Bitmap(exList[currentEx].GetExercisePath()); //Create new Bitmap (image) with the exercise image path 
            exPreview.Image = ex;

            currentLoc.Text = (currentEx + 1).ToString() + " / " + exList.Count.ToString(); //Show the current exercise index 



        }
        /// <summary>
        /// Insert's the subjects into a combo box when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateExam_Load(object sender, EventArgs e)
        {
            showAll = false;
            viewAllEx.ForeColor = Color.Green;
            sub = new SubjectsBL();
            teacher = LoginForm.teacher;
            List<string> subjectnamelist = manager.GetAllSubjectNames();
            exam = new List<ExercisesBL>();
            subjectnamelist.Insert(0, "בחר נושא");
            SubjectCombo.DataSource = subjectnamelist; //Set subject list combobox
            exPreview.SizeMode = PictureBoxSizeMode.StretchImage; // set picturebox size
            currentEx = 0;
            
        }

        private void rightEx_Click(object sender, EventArgs e)
        {
            if (exList == null || currentEx == exList.Count - 1)
            {
                return;
            }
            currentEx = currentEx + 1;
            currentLoc.Text = (currentEx + 1).ToString() + " / " + exList.Count.ToString();// current location starts with 0, [current location +1] / [number of exercises]
            if (exam.Contains(exList[currentEx])) // if the exam already contains the showen ex
            {
                addEx.Text = "הסר תרגיל";
                addEx.ForeColor = Color.Red;
            }
            else
            {
                addEx.Text = "הוסף תרגיל";
                addEx.ForeColor = Color.Black;
            }
            Bitmap ex = new Bitmap(exList[currentEx].GetExercisePath()); // Insert's the chosen Exercise path 
            exPreview.Image = ex; // preview the exercise at the picture box
        }

        private void leftEx_Click(object sender, EventArgs e)
        {
            if (currentEx == 0)
            {
                return;
            }
            currentEx = currentEx - 1;
            currentLoc.Text = (currentEx + 1).ToString() + " / " + exList.Count.ToString(); //Show the current exercise index 
            if (exam.Contains(exList[currentEx])) // if the exam already contains the showen ex
            {
                addEx.Text = "הסר תרגיל";
                addEx.ForeColor = Color.Red;
            }
            else
            {
                addEx.Text = "הוסף תרגיל";
                addEx.ForeColor = Color.Black;
            }
            Bitmap ex = new Bitmap(exList[currentEx].GetExercisePath());//Create new Bitmap (image) with the exercise image path 
            exPreview.Image = ex; // preview the exercise at the picture box
        }

        /// <summary>
        /// while clicking the create button, if everything is in the correct format, it will create the exam and add him to the access table and show a message it added
        /// if it's not in the correct format and the exam cant be created, it will show an error messagebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void create_Click(object sender, EventArgs e)
        {
            string name = examName.Text;
            string rules = examRules.Text;
            DateTime date = dateT.Value;
            int r = teacher.AddExam(name, exam, date, rules);
            if (r != 0)
            {
                MessageBox.Show("המבחן נוצר בהצלחה!");
            }
            else
            {
                MessageBox.Show("הוספת המבחן נכשלה!");
            }
        }
        /// <summary>
        /// while clicking the AddEx Button, it will add the chosen exercise into the exam and if he will click it again, it will remove it from the exam
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addEx_Click(object sender, EventArgs e)
        {
            if (exList != null)
            {
                if (exam.Contains(exList[currentEx]))
                {
                    addEx.Text = "הוסף תרגיל";
                    addEx.ForeColor = Color.Black;
                    exam.Remove(exList[currentEx]);
                }
                else
                {
                    addEx.Text = "הסר תרגיל";
                    addEx.ForeColor = Color.Red;
                    exam.Add(exList[currentEx]);
                }
            }
            else
            {
                MessageBox.Show("אנא בחרו נושא להצגת התרגילים");
            }

        }

        private void GoBackButton_Click(object sender, EventArgs e)
        {
            TeacherMainForm f1 = new TeacherMainForm(manager);
            f1.Show();
            this.Hide();
        }

        private void viewAllEx_Click(object sender, EventArgs e)
        {
            if (!showAll) //if showAll = false show all exercsises
            {
                showAll = true;
                viewAllEx.Text = "הצג תרגילים מומלצים";
                viewAllEx.ForeColor = Color.Red;
                currentEx = 0;
                int sub = manager.GetSubjectID(SubjectCombo.Text); // gets the id of the selected subject at the combo box
                if ((exList = manager.GetAllOrderedByStatsExBySub(sub)) == null) // sort's the exercises In order by best satistics
                {
                    currentLoc.Text = " 0/ 0";
                    exPreview.Image = null;
                    leftEx.Enabled = false;
                    rightEx.Enabled = false;
                    return;
                }
                leftEx.Enabled = true;
                rightEx.Enabled = true;
                currentEx = 0;
                if (exam.Contains(exList[currentEx])) // if the exam already contains the showen ex
                {
                    addEx.Text = "הסר תרגיל";
                    addEx.ForeColor = Color.Red;
                }
                else
                {
                    addEx.Text = "הוסף תרגיל";
                    addEx.ForeColor = Color.Black;
                }
                Bitmap ex = new Bitmap(exList[currentEx].GetExercisePath()); //Create new Bitmap (image) with the exercise image path 
                exPreview.Image = ex;
                currentLoc.Text = (currentEx + 1).ToString() + " / " + exList.Count.ToString(); //Show the current exercise index 
            }
            else
            {
                showAll = false ;
                viewAllEx.Text = "הצג את כל התרגילים";
                viewAllEx.ForeColor = Color.Green;
                subjects_SelectedIndexChanged(sender, e); //Call combobox change event in order to show the first 3 exercises
            }

        }
    }
}
