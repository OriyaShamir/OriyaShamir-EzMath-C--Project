using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL_Project;

namespace EZMath
{
    public partial class LoginForm : Form
    {
        private ManagerBL manager;
        public static TeachersBL teacher;
        private Validator valid;

        public LoginForm()
        {
            valid = new Validator();
            InitializeComponent();
            manager = new ManagerBL();
        }

      

        /// <summary>
        /// if username or password is still empty it will show an error message
        /// checks if the teacher auth, unless it will show an error message
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Click(object sender, EventArgs e)
        {
            string uname = Username.Text;
            string pass = Password.Text;
            LblCheck.Text = "";
            if (uname.Equals("") || pass.Equals(""))
            {
                LblCheck.Text = "הזן שם משתמש וסיסמא";
            }
            else
            {
                bool isValid = true;
              /*  if (!valid.checkpass(pass))
                {
                    LblCheck.Text += "סיסמא אינה תקינה\n";
                    isValid = false; 
                }    */
                if(!valid.checkuser(uname))
                {
                    LblCheck.Text += "שם משתמש אינו תקין\n";
                    isValid = false;
                }
                if (!isValid)
                {
                    return;
                }
                teacher = manager.AuthTeacher(uname, pass);
                if (teacher != null)
                {
                    LblCheck.Text = "התחברת בהצלחה!";
                    TeacherMainForm f1 = new TeacherMainForm(manager);
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    LblCheck.Text = "שם משתמש או סיסמא שגויים";
                }
            }                   
        }

    }
}
