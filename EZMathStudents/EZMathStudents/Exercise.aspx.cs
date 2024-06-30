using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BL_Project;

namespace EZMathStudents
{
    public partial class home : System.Web.UI.Page
    {
        private static StudentsBL st;
        public static string subjectForm;
        static SubjectsBL  sub;
        private static int currLoc;
        public static string exPath, exSolPath;
        public static List<ExercisesBL> l;
        private static ExercisesBL currEx;
        public static string likes, dislikes;

        protected void Page_Load(object sender, EventArgs e)
        {
            sub = new SubjectsBL();
            if (l == null)
            {
                l = new List<ExercisesBL>();
            }
            if (Session["St"] != null) // if student is logged in
            {
                st = (StudentsBL)Session["St"];
                if (subjectForm == null || subjectForm== "" ) // Insert's the subjects into a dictionary subs
                {
                    Dictionary<string, int> subs = sub.GetAllSubjectsNameID();
                    subjectForm = "";
                    foreach (KeyValuePair<string, int> s in subs) // foreach string and int, Insert it to subjectForm (it's a string)
                    {
                        subjectForm += "<option value = \"" + s.Value + "\" >" + s.Key + "</option>";
                    }
                }
                if(currEx != null) // if current exercise isn't null, u can Insert likes and dislikes, 
                {
                    currEx = l[currLoc];
                    likes = currEx.GetLikes().ToString();
                    dislikes = currEx.GetDisLikes().ToString();
                    exPath = "<img src = \"" + currEx.GetExercisePath() + "\" >"; // gets the image path to exPath 
                }
            }
        }

        protected void btnLeft_Click(object sender, EventArgs e)
        {
            if (currLoc > 0)
            {
                currLoc--;
                currEx = l[currLoc];
                exSolPath = "";
                exPath = "<img src = \"" + currEx.GetExercisePath() + "\">"; // gets the image path to exPath
            }
            else
            {
                currEx = l[currLoc];
                exPath = "<img src = \"" + currEx.GetExercisePath() + "\" >"; // gets the image path to exPath
            }
        }

        protected void btnRight_Click(object sender, EventArgs e)
        {
            if (currLoc < l.Count - 1)
            {
                currLoc++;
                currEx = l[currLoc];
                exSolPath = "";
                exPath = "<img src = \"" + currEx.GetExercisePath() + "\" >"; 
            }
            else
            {
                currEx = l[currLoc];
                exPath = "<img src = \"" + currEx.GetExercisePath() + "\"  >";
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
            exSolPath = "";
            exPath = "";
                int subject = int.Parse(Request.Form["Subject"]); // Insert's the Subjects into int subject
                l = st.getExForStudentBySubOrdered(subject); // Insert's to list all Exercises of the subject chosen
            if (l != null && l.Count >0) // if there is atleast 1 exercise in the list and list isn't null
            {
               currLoc = 0;
               currEx = l[currLoc];
               exPath = "<img src = \"" + currEx.GetExercisePath() + "\" >";
                btnLeft.Visible = true;
                btnRight.Visible = true;
                btnLike.Visible = true;
                btnDislike.Visible = true;
                ShowAns.Visible = true;
                likes = currEx.GetLikes().ToString();
                dislikes = currEx.GetDisLikes().ToString();
            }
            else
            {
                btnLeft.Visible = false;
                btnRight.Visible = false;
                btnLike.Visible = false;
                btnDislike.Visible = false;
                ShowAns.Visible = false;
                likes = "";
                dislikes = "";
                exPath = "<h1> אין תרגילים ברמת הקושי והנושא שנבחרו </h1>";
            }
        }

        protected void Like_Click(object sender, EventArgs e)
        {
         
            st.like(currEx.GetExid(), true); // Insert like
            likes = currEx.GetLikes().ToString(); // get ex likes
            dislikes = currEx.GetDisLikes().ToString(); // get ex dislikes

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Response.Redirect("MainScreen.aspx");
        }

        protected void Dislike_Click(object sender, EventArgs e)
        {

            st.like(currEx.GetExid(), false); // insert dislike
            likes = currEx.GetLikes().ToString(); // get ex likes
            dislikes = currEx.GetDisLikes().ToString(); // get ex dislikes

        }

        protected void ShowAns_Click(object sender, EventArgs e)
        {

              if (exSolPath != "" && exSolPath != null) // if there is an AnswerPath
              {
                  exSolPath = "";
                ShowAns.Text = "הצג פתרון";
            }
              else
              {
                  exSolPath = "<img src = \"" + currEx.GetAnswerRes() + "\" width=\"300\" height=\"300\" >"; // Insert's the Answers image
                  ShowAns.Text = "הסתר פתרון";
              }

            
        }
    }
}