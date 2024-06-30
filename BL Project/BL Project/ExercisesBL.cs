using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using System.Data;

namespace BL_Project
{
    public class ExercisesBL
    {
        private string exercisePath;
        private int subject;
        private int diff;
        private int exid;
        private string AnswerRes;
        private int CreatorID;
        private double exavg;

        public ExercisesBL()
        {
        }
        /// <summary>
        /// Insert Exercise
        /// Path, Exercise Subject, Exercise Difficulty(3,4,5), Exercise Answers, Exercise Creator, Exercise ID, and Exercise Avg
        /// </summary>
        /// <param name="exercisePath">תרגיל</param>
        /// <param name="subject">נושא תרגיל</param>
        /// <param name="diff">רמת קושי של תלמיד - 3 יחל , 4 יחל , 5 יחל</param>
        /// <param name="Ans">תשובה של התרגיל</param>
        /// <param name="CreatorID">המורה שהכניס את התרגיל</param>
        public ExercisesBL(string exercisePath, int subject, int diff, string Ans, int CreatorID, int exid, double avg)
        {
            this.exid = exid;
            this.exercisePath = exercisePath;
            this.subject = subject;
            this.diff = diff;
            this.AnswerRes = Ans;
            this.CreatorID = CreatorID;
            this.exavg = avg;

        }
        /// <summary>
        /// Get's All exercises Likes
        /// </summary>
        /// <returns></returns>
        public int GetLikes()
        {
            return Likes.GetLikesForEx(this.exid);
        }
        /// <summary>
        /// Get's All exercises dislikes
        /// </summary>
        /// <returns></returns>
        public int GetDisLikes()
        {
            return Likes.GetDisLikesForEx(this.exid);
        }
        /// <summary>
        /// Get's the exercise path (picture)
        /// </summary>
        /// <returns></returns>
        public string GetExercisePath()
        {
            return this.exercisePath;
        }
        /// <summary>
        /// Get's the exercise subject
        /// </summary>
        /// <returns></returns>
        public int GetSubject()
        {
            return this.subject;
        }
        /// <summary>
        /// get's the exercise difficulty
        /// </summary>
        /// <returns></returns>
        public int GetDiff()
        {
            return this.diff;
        }
        /// <summary>
        /// get's the exercise answers
        /// </summary>
        /// <returns></returns>
        public string GetAnswerRes()
        {
            return this.AnswerRes;
        }
        /// <summary>
        /// get's the exercise ID
        /// </summary>
        /// <returns></returns>
        public int GetExid()
        {
            return this.exid;
        }
        /// <summary>
        /// Return's the exercise avg
        /// </summary>
        /// <returns></returns>
        public double GetExAvg()
        {
            return this.exavg;
        }
    }
}
