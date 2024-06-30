using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL_Project;

namespace EZMathStudents
{
    public partial class MainScreen : System.Web.UI.Page
    {
        private static StudentsBL st;
        public static string helloMsg;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["St"] != null) // if student is logged in 
            {
                st = (StudentsBL)Session["St"];
                helloMsg = String.Format("{0} ברוך הבא", st.GetName()); // add his name to helloMsg
            }
            
        }

        protected void Exercise_Click(object sender, EventArgs e)
        {
            Response.Redirect("Exercise.aspx");
        }

        protected void Grades_Click(object sender, EventArgs e)
        {
            Response.Redirect("MyGrades.aspx");
        }

        protected void Edit_Click(object sender, EventArgs e)
        {
            Response.Redirect("Edit.aspx");
        }
        protected void LogOut_Click(object sender, EventArgs e)
        {
            Response.Redirect("Login.aspx");
            Session["StudentID"] = null; // get student id
            Session["StudentName"] = null; // get student name
            Session["St"] = null; // St is the student connected 
        }
    }
}