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
        private StudentsBL st;
        public string subjectForm;
        SubjectsBL sub;
        private int currLoc;
        public string exPath;
        public List<ExercisesBL> l;
        private ExercisesBL currEx;


        protected void Page_Load(object sender, EventArgs e)
        {
            this.sub = new SubjectsBL();
            if (this.l == null)
            {
                this.l = new List<ExercisesBL>();
            }
            currLoc = 0;
            if (Session["St"] != null)
            {
                this.st = (StudentsBL)Session["St"];
                Dictionary<string, int> subs = sub.GetAllSubjectsNameID();

                subjectForm = "";
                foreach (KeyValuePair<string, int> s in subs)
                {
                    subjectForm += "<option value = \"" + s.Value + "\" >" + s.Key + "</option>";
                }
            }
        }

        protected void btnLeft_Click(object sender, EventArgs e)
        {
            if (currLoc > 0)
            {
                currLoc--;
                currEx = l[currLoc];
                exPath = "<img src = \"" + currEx.GetExercisePath() + "\" >";
            }
        }

        protected void btnRight_Click(object sender, EventArgs e)
        {
            if (currLoc < l.Count - 1)
            {
                currLoc++;
                currEx = l[currLoc];
                exPath = "<img src = \"" + currEx.GetExercisePath() + "\" >";
            }
        }

        protected void submit_Click(object sender, EventArgs e)
        {
                int subject = int.Parse(Request.Form["Subject"]);
                l = st.getExForStudentBySubOrdered(subject);
                if (l.Count > 0)
                {
                    currLoc = 0;
                    currEx = l[currLoc];
                    exPath = "<img src = \"" + currEx.GetExercisePath() + "\" >";
                }
        }
    }
}