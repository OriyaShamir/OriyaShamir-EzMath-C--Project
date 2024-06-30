using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL_Project;

namespace EZMathStudents
{
    public partial class Register : System.Web.UI.Page
    {
        ManagerBL manager;
        public string classesForm;
        public string errors;
        protected void Page_Load(object sender, EventArgs e)
        {
            manager = new ManagerBL();
            Dictionary<string, int> classes = manager.GetClassNames(); // get all classes name into a dictionary (class name and class id)
            classesForm = "";          
            foreach (KeyValuePair<string, int> cl in classes) // for each class name and id
            {
                classesForm += "<option value = \"" + cl.Value + " \" > "+ cl.Key + "</option>";  // Insert it to a string ClassesForm, cl.key = ClassName. cl.Val = ClassID
            }
            if (Request.Form["submit"] != null) 
            {
                string uname = Request.Form["uname"];
                string pass = Request.Form["pass"];
                string fname = Request.Form["fname"];
                string email = Request.Form["email"];
                int gender = int.Parse(Request.Form["gender"]);
                int diff = int.Parse(Request.Form["diff"]);
                int classId = int.Parse(Request.Form["Class"]);
                if (manager.InsertStudent(uname, pass, email, gender, fname, classId, diff)) // if student Exsits
                {
                    Response.Write("<script> alert('נרשמת בהצלחה') </script>");
                }
                else
                {
                    errors += "הרשמה נכשלה";
                }
            
            }
        }
    }
}