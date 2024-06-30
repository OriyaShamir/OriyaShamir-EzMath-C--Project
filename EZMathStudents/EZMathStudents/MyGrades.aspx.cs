using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL_Project;

namespace EZMathStudents
{
    public partial class MyGrades : System.Web.UI.Page
    {
        private static StudentsBL st;
        public static string ExamList;
        public static string ExamGrade;
        public static string ExamEx;
        public string cssClass = "Test";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["St"] != null) //If logged in
            {
                st = (StudentsBL)Session["St"];
                if (ExamList == null || ExamList == "") // if there isn't exams for the students
                {
                    Dictionary<string, int> exams = st.GetStudentExams(); //Insert to dictionary all student exams (name and id)
                    ExamList = "";
                    foreach (KeyValuePair<string, int> exam in exams)
                    {
                        ExamList += "<option value = \"" + exam.Value + "\" >" + exam.Key + "</option>"; // Insert's to string ExamList all the exam names and ID
                    }
                }
            }

        }
        protected void submit_Click(object sender, EventArgs e)
        {
            int exam = int.Parse(Request.Form["Exam"]); 
            ExamGrade = String.Format("ציון המבחן {0}",st.getGrade(exam)); // Insert the grade of the student Exam
            List<StudentGrade> ExamExGrades = st.getExGradesOfExam(exam); // Insert's a list all the grades of the exercises in a student exam
            TestGradeShow.Text = ExamGrade;
            ExamEx = "";
            foreach (StudentGrade grade in ExamExGrades) // foreach grade in exercise of the exam
            {
                ExamEx += "<tr>";
                ExamEx += "<td>";
                ExamEx +=  "<img src = \"" + grade.getPath() + "\" >"; // get's the exercise of the grade
                ExamEx += "</td>";
                ExamEx += "<td class='ExerStyle'>";
                ExamEx += "ציון התרגיל: ";
                ExamEx += grade.getGrade(); //  get's the grade
                ExamEx += "</td>";
                ExamEx += "</tr>";
            }
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainScreen.aspx");
        }
    }
}