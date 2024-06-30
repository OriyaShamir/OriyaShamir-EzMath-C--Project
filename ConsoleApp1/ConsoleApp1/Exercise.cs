using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp1
{
   public class Exercise
    {

        /// <summary>
        /// Insert Exercise with his subject , his difficulty level , answers of the exercise and the creator of the exercise(teacherID)
        /// </summary>
        /// <param name="text"></param>
        /// <param name="sub"></param>
        /// <param name="diff"></param>
        /// <param name="stat"></param>
        /// <returns></returns>
        static public int InsertExercise(string extext, int subid, int exdiff,string exanswerRes, int creator_id) 
        {
            string sSql = "INSERT INTO tblExercises (ExercisePath,SubjectID,Difficulty,AnswerRes, CreatorID, Score) " +
                                "VALUES ('" + extext + "'," + subid + ","  + exdiff + ",'" + exanswerRes + "', "+creator_id+", 0)";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }
        /// <summary>
        /// Updates The Exercise Path(image)
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="exerciseID"></param>
        /// <returns></returns>
        static public int UpdateExercisePath(string exPath, int exerciseID)
        {
            string sSql = "UPDATE tblExercises SET ExercisePath ='" +
                        exPath + "' WHERE ExerciseID = " + exerciseID + ";";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }

        /// <summary>
        /// Update Exercise Score (likes)
        /// </summary>
        /// <param name="Text"></param>
        /// <param name="exerciseID"></param>
        /// <returns></returns>
        static public int UpdateExerciseScore(int exid, bool liked)
        {
            string sSql;
            if (liked)
            {
                sSql = "UPDATE tblExercises SET Score = Score +1 WHERE ExerciseID = " + exid+";";
            }
            else
            {
                sSql = "UPDATE tblExercises SET Score = Score -1 WHERE ExerciseID = " + exid + ";";
            }
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }

        /// <summary>
        /// Update Exercise Subject
        /// </summary>
        /// <param name="subject"></param>
        /// <param name="exerciseID"></param>
        /// <returns></returns>
        static public int UpdateExerciseSubject(int subjectid, int exerciseID)
        {
            string sSql = "UPDATE tblExercises SET SubjectID = " +
                       subjectid + " WHERE ExerciseID = " + exerciseID + ";";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }

        /// <summary>
        /// Update Exercise Difficulty
        /// </summary>
        /// <param name="diff"></param>
        /// <param name="exerciseID"></param>
        /// <returns></returns>
        static public int UpdateExerciseDiff(int exdiff, int exerciseID)
        {
            string sSql = "UPDATE tblExercises SET Difficulty = " +
                       exdiff + " WHERE ExerciseID = " + exerciseID + ";";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }
        /// <summary>
        /// Gets exercise path
        /// </summary>
        /// <param name="ExerciseID"></param>
        /// <returns></returns>
        static public string GetExercisePath(int ExerciseID)
        {
            string sSql = "SELECT ExercisePath " +
                                "FROM tblExercises " +
                                "WHERE ExerciseID = " + ExerciseID + "";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt !=null && dt.Rows.Count != 0){
                return dt.Rows[0]["ExercisePath"].ToString();
            }
            return "";
        }

        /// <summary>
        /// Gets the exercise by the difficulty
        /// </summary>
        /// <param name="diff"></param>
        /// <returns></returns>
        public static DataTable GetExByDiff(int exdiff) // Ex - Exercise 
        {
            string sSql = "SELECT * FROM tblExercises WHERE Difficulty = " + exdiff+ ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dt;
            }
        }
        /// <summary>
        /// Get Exercises Paths by the ex difficulty and the ex subject
        /// </summary>
        /// <param name="exdiff"></param>
        /// <param name="exsub"></param>
        /// <returns></returns>
        public static DataTable GetExPathsByDiffAndSub(int exdiff, int exsub)
        {
            string sSql = "SELECT * FROM tblExercises WHERE SubjectID = " + exsub + " AND Difficulty = "+exdiff + ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dt;   
            }
        }

        /// <summary>
        /// Gets the exercise paths by the subject
        /// </summary>
        /// <param name="sub"></param>
        /// <returns></returns>
        public static DataTable GetExBySub(int exsub) // sub - Subject
        {
            string sSql = "SELECT * " +
                "FROM tblExercises" +
                " WHERE SubjectID = " + exsub + " ;";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dt;
            }
        }

        /// <summary>
        /// Gets the exercise paths by the subject and difficulty orderd by score
        /// </summary>
        /// <param name="sub"></param>
        /// <returns></returns>
        public static DataTable GetExBySubAndDiffOrdered(int exsub, int diff)
        {
            string sSql = "SELECT * FROM tblExercises WHERE Difficulty = " + diff + " AND SubjectID = " + exsub + " ORDER BY Score DESC";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dt;
            }
        }


        /// <summary>
        /// check if the given exercise is already exist
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        static public bool IsExist(string path)
        {
            string sSql = "SELECT *" +
                                "FROM tblExercises " +
                                "WHERE ExercisePath = '" + path + "';";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        /// <summary>
        /// Get exercises by creator
        /// </summary>
        /// <param name="Creator"></param>
        /// <returns></returns>
        public static DataTable GetExByCreator(int Creator) // sub - Subject
        {
            string sSql = "SELECT * FROM tblExercises WHERE CreatorID = " + Creator+ ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                return dt;
            }
        }
        /// <summary>
        /// get all exercises of the subject
        /// </summary>
        /// <param name="subid"></param>
        /// <returns></returns>
        public static DataTable GetAllExBySubject(int subid)
        {
            string sSql = "Select tblExercises.ExerciseID, tblExercises.ExercisePath, tblExercises.SubjectID, tblExercises.Difficulty, tblExercises.AnswerRes, tblExercises.CreatorID " +
                "FROM tblExercises " +
                "WHERE SubjectID = " + subid + ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null)
                return dt;
            else
                return null;
        }


        /// <summary>
        /// Delete exercise by it's ID
        /// </summary>
        /// <param name="exid"></param>
        /// <returns></returns>
        static public int DeleteEx(int exid)
        {
            string sSql = "DELETE FROM tblExercises WHERE ExerciseID = " + exid + ";";
            int rowsaffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsaffected;
        }

        }
}
