using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL_Project;

namespace EZMathStudents
{
    public partial class Login : System.Web.UI.Page
    {
        ManagerBL manager;
        public string errors = "";
        public StudentsBL student;
        protected void Page_Load(object sender, EventArgs e)
        {
            manager = new ManagerBL();
            if (Request.Form["submit"] != null) 
            {
                string uname = Request.Form["uname"];
                string pass = Request.Form["pass"];
                student = manager.AuthStudent(uname, pass);
                if (student != null) // if student is auth
                {
                    Session["StudentID"] = student.GetStudentID(); // get student id
                    Session["StudentName"] = student.GetstudentName(); // get student name
                    Session["St"] = student; // St is the student connected 
                    Response.Redirect("MainScreen.aspx");
                }
                else
                {
                    errors += "שם משתמש או סיסמא שגויים";
                }
            }
        }
    }
}