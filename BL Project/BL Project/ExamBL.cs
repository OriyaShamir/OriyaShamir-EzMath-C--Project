using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using System.Data;

namespace BL_Project
{
    public class ExamBL
    {
        private string examName;
        private int examTeacher;
        private string examDate;
        private int examID;
        private List<ExercisesBL> ExamExercises;
        private string examRules;

        public ExamBL()
        {
        }
        /// <summary>
        /// Create an Exam oject with a list of it's exercises.
        /// </summary>
        /// <param name="examID"></param>
        /// <param name="examName"></param>
        /// <param name="examTeacher"></param>
        /// <param name="examDate"></param>
        public ExamBL(int examID, string examName, int examTeacher,string examDate, string examRules)
        {
            this.examRules = examRules;
            this.examName = examName;
            this.examTeacher = examTeacher;
            this.examDate = examDate;
            this.examID = examID;
            DataTable dt = ExamExExercises.GetExamExercises(this.examID); // מקבל את תרגילי המבחן למערך
            List<ExercisesBL> l = new List<ExercisesBL>();
            string exercisePath;
            int subject;
            int diff;
            int exid;
            string AnswerRes;
            int CreatorID;
            for (int i = 0; dt!= null && i < dt.Rows.Count; i++)
            {
                exercisePath = dt.Rows[i]["ExercisePath"].ToString();
                subject = int.Parse(dt.Rows[i]["SubjectID"].ToString());
                diff = int.Parse(dt.Rows[i]["Difficulty"].ToString());
                AnswerRes = dt.Rows[i]["AnswerRes"].ToString();
                exid = int.Parse(dt.Rows[i]["ExerciseID"].ToString());
                CreatorID = int.Parse(dt.Rows[i]["CreatorID"].ToString());
                l.Add(new ExercisesBL(exercisePath, subject, diff, AnswerRes, CreatorID, exid,Answers.GetExStats(exid)));
            }
            this.ExamExercises = l;
        }
        /// <summary>
        /// Insert's all the created exam exercises to a list 
        /// </summary>
        /// <param name="examName"></param>
        public ExamBL(string examName)
        {
            DataTable d = Exam.GetExamByName(examName); // Get's the exam name
            if (d == null || d.Rows.Count == 0)
            {
                return;
            }
            this.examDate = d.Rows[0]["ExamDate"].ToString();
            this.examName = d.Rows[0]["ExamName"].ToString();
            this.examID = int.Parse(d.Rows[0]["ExamID"].ToString());
            this.examRules = d.Rows[0]["ExamRules"].ToString();
            this.examTeacher = int.Parse(d.Rows[0]["TeacherID"].ToString());
            DataTable dt = ExamExExercises.GetExamExercises(this.examID); // get exam exercises by the id
            List<ExercisesBL> l = new List<ExercisesBL>();
            string exercisePath;
            int subject;
            int diff;
            int exid;
            string AnswerRes;
            int CreatorID;
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                exercisePath = dt.Rows[i]["ExercisePath"].ToString();
                subject = int.Parse(dt.Rows[i]["SubjectID"].ToString());
                diff = int.Parse(dt.Rows[i]["Difficulty"].ToString());
                AnswerRes = dt.Rows[i]["AnswerRes"].ToString();
                exid = int.Parse(dt.Rows[i]["ExerciseID"].ToString());
                CreatorID = int.Parse(dt.Rows[i]["CreatorID"].ToString());
                l.Add(new ExercisesBL(exercisePath, subject, diff, AnswerRes, CreatorID, exid, Answers.GetExStats(exid))); // Adds all exam exercises in a list
            }
            this.ExamExercises = l; 
        }
        /// <summary>
        /// get's current exam name
        /// </summary>
        /// <returns></returns>
        public string GetexamName()
        {
            return this.examName;
        }
        /// <summary>
        /// get's the creator of the exam (The teacher)
        /// </summary>
        /// <param name="examTeacher"></param>
        /// <returns></returns>
        public int GetexamTeacher(int examTeacher)
        {
            return examTeacher;
        }
        /// <summary>
        /// return's the exam rules
        /// </summary>
        /// <returns></returns>
        public string GetExamRules()
        {
            return this.examRules;
        }
        /// <summary>
        /// return's the Exam Exercises
        /// </summary>
        /// <returns></returns>
        public List<ExercisesBL> GetExercises()
        {
            return this.ExamExercises;
        }
        /// <summary>
        /// return the ExamID
        /// </summary>
        /// <returns></returns>
        public int GetExamID()
        {
            return this.examID;
        }
        /// <summary>
        /// return's the exam Date
        /// </summary>
        /// <returns></returns>
        public string GetExamDate()
        {
            return this.examDate;
        }
    }
}
