using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using System.Data;

namespace BL_Project
{
    public class SubjectsBL
    {
        private string subjectText;
        private List<ExercisesBL> Exercises;
        private int subjectID;
        private ManagerBL manager = new ManagerBL();
        public SubjectsBL()
        {                    
        }
        /// <summary>
        /// Get's all the Exercises of the current subject and Insert's all the exercises of the specific subject into a list (ExercisesBL List)
        /// </summary>
        /// <param name="subjectText"></param>
        /// <param name="subjectID"></param>
        public SubjectsBL(string subjectText, int subjectID)
        {
            this.subjectText = subjectText;
            this.subjectID = subjectID;
            DataTable dt = Exercise.GetAllExBySubject(this.subjectID); // Get's all the Exercises of the current subject 
            Exercises = new List<ExercisesBL>();
            int id;
            string path;
            int subid;
            int diff;
            string answerres;
            int creatorid;
            ExercisesBL ex;         
            for (int i = 0; i < dt.Rows.Count; i++) // Insert's all the exercises of the specific subject into a list (ExercisesBL List)
            {
                ex = new ExercisesBL();
                path = dt.Rows[i]["ExercisePath"] + "";
                subid = int.Parse(dt.Rows[i]["SubjectID"] + "");
                diff = int.Parse(dt.Rows[i]["Difficulty"] + "");
                answerres = dt.Rows[i]["AnswerRes"] + "";
                creatorid = int.Parse(dt.Rows[i]["CreatorID"] + "");
                id = int.Parse(dt.Rows[i]["ExerciseID"] + "");
                ex = new ExercisesBL(path, subid, diff, answerres, creatorid, id, Answers.GetExStats(id));
                this.Exercises.Add(ex); // add's all the exercises to the list 
            }

        }
        /// <summary>
        /// Get a list of all subjects
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetAllSubjectsNameID()
        {
            DataTable dt = Subjects.GetAllSubjects();
            Dictionary<string, int> l = new Dictionary<string, int>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                l.Add(dt.Rows[i]["SubjectText"].ToString(), int.Parse(dt.Rows[i]["SubjectID"].ToString()));
            }
            return l;
        }
        /// <summary>
        /// Return's subject ID
        /// </summary>
        /// <returns></returns>
        public int GetSubjectID()
        {
            return subjectID;
        }
        /// <summary>
        /// Returns Subject Text
        /// </summary>
        /// <returns></returns>
        public string GetsubjectText()
        {
            return subjectText;
        }
        /// <summary>
        /// Return's a list with the subject Exercises
        /// </summary>
        /// <returns></returns>
        public List<ExercisesBL> GetSubExercises()
        {
            return this.Exercises;
        }       
    }
}
