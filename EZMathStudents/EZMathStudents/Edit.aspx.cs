using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL_Project;

namespace EZMathStudents
{
    public partial class Edit : System.Web.UI.Page
    {
        private static StudentsBL st;
        public static string error;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Form["submit"] != null) 
            {
                if (Session["St"] != null) //If logged in
                {
                    error = "";
                    st = (StudentsBL)Session["St"];
                    string oldP = Request.Form["oldPass"];
                    string newP = Request.Form["newPass"];
                    int diff = int.Parse(Request.Form["diff"]);

                    bool changeP = st.Changepass(oldP, newP); // change password
                    bool changeD = st.changeDiff(diff); // change diff 
                    if (!changeP)
                    {
                        error += "החלפת סיסמה נכשלה";
                    }
                    if (!changeD)
                    {
                        error += "שינוי רמת קודי נכשל";
                    }
                    if (changeP && changeD)
                    {
                        error = "פרטים שונו בהצלחה";
                    }
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("MainScreen.aspx");
        }
    }
}