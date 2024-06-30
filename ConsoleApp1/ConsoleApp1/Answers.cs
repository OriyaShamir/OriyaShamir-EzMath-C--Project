using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp1
{
    public class Answers
    {

        /// <summary>
        /// Check if the given combination of student, exam and exercise already exists.
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="examId"></param>
        /// <param name="exId"></param>
        /// <returns></returns>
        public static int IsExist(int studentID, int examId, int exId)
        {
            string sSql = "SELECT * FROM tblAnswers WHERE StudentID = " + studentID + " AND ExamID = " + examId + " AND ExerciseID = " + exId + ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return 1;
            }
            return 0;
        }
        /// <summary>
        /// Insert Answer Result of exercise in exam by student
        /// </summary>
        /// <param name="answerResult"></param>
        /// <param name="studentID"></param>
        /// <param name="examID"></param>
        /// <param name="exerciseID"></param>
        /// <returns></returns>
        public static int InsertAnswer(int  answerResult, int studentID, int examID,int exerciseID)
        {
            string sSql = "INSERT INTO tblAnswers (AnswerRes,StudentID,ExamID,ExerciseID) " +
                                "VALUES (" + answerResult + "," + studentID + "," + examID + "," + exerciseID +")";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }
        /// <summary>
        /// Get AnswerResult by AnswerID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable GetResById(int id)
        {
            string sSql = "SELECT * " +
                                "FROM tblAnswers " +
                                "WHERE AnswerID = " + id + ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }
        /// <summary>
        /// Update Answer
        /// </summary>
        /// <param name="answerResult"></param>
        /// <param name="answerID"></param>
        /// <returns></returns>
        static public int UpdateAnswerResult(int answerResult, int examID, int exerciseId, int studentID)
        {
            string sSql = "UPDATE tblAnswers SET AnswerRes =" +
                        answerResult + " WHERE ExamID = " + examID + " AND ExerciseID = "+exerciseId+" AND StudentID = "+studentID+";";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }


        /// <summary>
        /// Get All Exam Exercises answers of specific student in specific exam
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="examID"></param>
        /// <returns></returns>
        static public DataTable GetExamAnswersByStudent(int studentID, int examID)
        {
            string sSql = "SELECT tblAnswers.ExerciseID, tblAnswers.AnswerRes, tblExercises.ExercisePath " +
                               "FROM tblAnswers INNER JOIN tblExercises ON tblAnswers.ExerciseID = tblExercises.ExerciseID " +
                               "WHERE StudentID = " + studentID + " AND ExamID = "+ examID+";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }


        /// <summary>
        /// Get grade of student in specific exercise and exam.
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="examId"></param>
        /// <param name="exId"></param>
        /// <returns></returns>
        public static int GetGradeInEx(int studentId, int examId, int exId)
        {
            string sSql = "SELECT AnswerRes FROM tblAnswers WHERE ExamID = " + examId + " AND StudentID  = " + studentId+" AND ExerciseID = "+exId+";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return int.Parse(dt.Rows[0]["AnswerRes"].ToString());
            }
            return -1;
        }

        /// <summary>
        /// Get the student exam grade (avg of all exercises grades)
        /// </summary>
        /// <param name="exam_id"></param>
        /// <param name="student_id"></param>
        /// <returns></returns>
        public static double GetGrade(int exam_id, int student_id)
        {
            string sSql = "SELECT tblAnswers.AnswerRes FROM tblAnswers WHERE ExamID = " + exam_id + " AND StudentID  = " + student_id;
            DataTable dt = DBHelper.GetDataTable(sSql);
            int rows = dt.Rows.Count;
            if ( rows == 0)
            {
                return -1;
            }
            else
            {
                double avg = 0;
                for (int i = 0; i < rows; i++)
                {
                    avg += double.Parse(dt.Rows[i]["AnswerRes"].ToString());
                }
                avg = avg / rows;
                return avg;
            }
        }
        /// <summary>
        /// Return the average grade of the specified exercise.
        /// </summary>
        /// <param name="exid"></param>
        /// <returns></returns>
        public static double GetExStats(int exid)
        {
            string sSql = "SELECT AnswerRes FROM tblAnswers WHERE ExerciseID = " + exid;
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt!=null && dt.Rows.Count != 0)
            {
                double sum = double.Parse(dt.Compute("AVG(AnswerRes)", string.Empty).ToString()); //summerize all the answer results
                return sum;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// Gets the satistic of the exercise for the teacher
        /// </summary>
        /// <param name="exid"></param>
        /// <param name="teacherID"></param>
        /// <returns></returns>
        public static double GetExStatsOfTeacher(int exid, int teacherID)
        {
            string sSql = "SELECT tblAnswers.AnswerRes FROM tblAnswers INNER JOIN Exam ON tblAnswers.ExamID = Exam.ExamID WHERE tblAnswers.ExerciseID = " + exid+" AND Exam.TeacherID = "+teacherID+";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null && dt.Rows.Count != 0)
            {
                double sum = double.Parse(dt.Compute("AVG(AnswerRes)", string.Empty).ToString()); //summerize all the answer results
                return sum;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Get the avg of teacher's exam
        /// </summary>
        /// <param name="examid"></param>
        /// <param name="teacherid"></param>
        /// <returns></returns>
        public static double GetAvgOfExamByTeacher(int examid, int teacherid)

        {
            string sSql = "SELECT tblAnswers.AnswerRes FROM tblAnswers INNER JOIN Exam ON tblAnswers.ExamID = Exam.ExamID WHERE tblAnswers.ExamID = " + examid + " AND Exam.TeacherID = " + teacherid + ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null && dt.Rows.Count != 0)
            {
                int amount = dt.Rows.Count;
                double sum = double.Parse(dt.Compute("SUM(AnswerRes)", string.Empty).ToString()); //summerize all the answer results
                return sum / amount;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// get statistics of specifies exercise in specifies exam
        /// </summary>
        /// <param name="exid"></param>
        /// <param name="examid"></param>
        /// <returns></returns>
        public static double GetStatsOfExInExam(int exid, int examid)
        {
            string sSql = "SELECT AnswerRes FROM tblAnswers WHERE ExerciseID = " + exid+" AND ExamID = "+examid;
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null && dt.Rows.Count != 0)
            {
                int amount = dt.Rows.Count;
                double sum = double.Parse(dt.Compute("SUM(AnswerRes)", string.Empty).ToString()); //summerize all the answer results
                return sum / amount;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// get statistics of specific exercise in specific exam within specific class
        /// </summary>
        /// <param name="exid"></param>
        /// <param name="examid"></param>
        /// <param name="classid"></param>
        /// <returns></returns>
        public static double GetStatsOfExInClass(int exid, int examid, int classid)
        {
            string sSql = "SELECT tblAnswers.AnswerRes FROM tblAnswers INNER JOIN tblStudents ON tblStudents.StudentID = tblAnswers.StudentID WHERE tblAnswers.ExerciseID = " + exid + " AND tblAnswers.ExamID = " + examid + " AND tblStudents.ClassID = " + classid + ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null && dt.Rows.Count != 0)
            {
                int amount = dt.Rows.Count;
                double sum = double.Parse(dt.Compute("SUM(AnswerRes)", string.Empty).ToString()); //summerize all the answer results
                return sum / amount;
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Get's all the Exams of specific student
        /// DISTINCT - so each exam won't be showen more then once
        /// </summary>
        /// <param name="stid"></param>
        /// <returns></returns>
        public static DataTable GetStudentExams(int stid)
        {
            string sSql = "SELECT DISTINCT Exam.ExamName,  Exam.ExamID FROM tblAnswers INNER JOIN Exam ON Exam.ExamID = tblAnswers.ExamID WHERE tblAnswers.StudentID = " + stid + ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }

    }
}
