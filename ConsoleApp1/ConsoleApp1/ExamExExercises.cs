using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ExamExExercises
    {
        /// <summary>
        /// Insert record for each exercise in the exam.
        /// </summary>
        /// <param name="exam_id"></param>
        /// <param name="ex_id"></param>
        /// <returns></returns>
        public static int InsertExam(int exam_id, int ex_id)
        {
            string sSql = "INSERT INTO ExamExAnswers (ExamID, ExerciseID) " +
                                "VALUES (" + exam_id + ","  + ex_id + ")";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }

        /// <summary>
        /// Return array contains all the exercise ids of the specified exam id.
        /// </summary>
        /// <param name="exam_id"></param>
        /// <returns></returns>
        public static DataTable GetExamExercises(int exam_id)
        {
            string sSql = "SELECT tblExercises.ExercisePath, tblExercises.SubjectID, tblExercises.Difficulty, tblExercises.AnswerRes, tblExercises.ExerciseID, tblExercises.CreatorID FROM ExamExAnswers INNER JOIN tblExercises ON tblExercises.ExerciseID = ExamExAnswers.ExerciseID WHERE ExamID = " + exam_id;
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }
        /// <summary>
        /// Get's all Exam Exercises Paths
        /// </summary>
        /// <param name="exam_id"></param>
        /// <returns></returns>
        public static DataTable GetExamExercisesText(int exam_id)
        {
            string sSql = "SELECT tblExercises.ExercisePath, tblExercises.SubjectID, tblExercises.Difficulty, tblExercises.AnswerRes, ExerciseID, tblExercises.CreatorID  FROM ExamExAnswers INNER JOIN tblExercises ON ExamExAnswers.ExamID = tblExercises.ExerciseID WHERE ExamExAnswers.ExamID = " + exam_id+";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }
    }
}
