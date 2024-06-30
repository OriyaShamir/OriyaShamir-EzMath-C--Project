using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp1
{
    public class Exam
    {
        /// <summary>
        /// Insert a new Exam 
        /// ExamDate, ExamName, ExamRules and the Exam Creator (teacherID)
        /// </summary>
        /// <param name="date"></param>
        /// <param name="name"></param>
        /// <param name="size"></param>
        /// <param name="Q"></param>
        /// <returns></returns>
        public static int InsertExam(string examdate, string examname, int teacherID, string examRules) 
        {
            string sSql = "INSERT INTO Exam (ExamDate, ExamName, TeacherID, ExamRules) " +
                                "VALUES ('" + examdate + "' , '" + examname + "', " + teacherID + ", '" + examRules +  "');";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }

        /// <summary>
        /// Updates the Exam Date
        /// </summary>
        /// <param name="examDate"></param>
        /// <param name="examID"></param>
        /// <returns></returns>
        static public int UpdateExamDate(string examDate, int examID)
        {
            string sSql = "UPDATE Exam SET ExamDate ='" +
                        examDate + "' WHERE ExamID = " + examID + ";";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }

        /// <summary>
        /// Get Exam by his ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable GetExamById(int examid)
        {
            string sSql = "SELECT * " +
                                "FROM Exam " +
                                "WHERE ExamID = " + examid + ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }

        /// <summary>
        /// Gets Exam Information by the Exam Name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static DataTable GetExamByName(string name)
        {
            string sSql = "SELECT * FROM Exam WHERE ExamName = '" + name + "'";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }
        /// <summary>
        /// check if the given ExamName alraedy exists
        /// </summary>
        /// <param name="examname"></param>
        /// <returns></returns>
        static public bool IsExist(string examname)
        {
            string sSql = "SELECT *" +
                                "FROM Exam " +
                                "WHERE ExamName = '" + examname + "';";
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
        /// Get Exam ID by its name
        /// </summary>
        /// <param name="examname"></param>
        /// <returns></returns>
        public static int GetExamIdByName(string examname)
        {
            string sSql = "SELECT ExamID " +
                               " FROM Exam " +
                               " WHERE ExamName = '" + examname + "';";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null && dt.Rows.Count > 0)
            {
                return int.Parse(dt.Rows[0]["ExamID"].ToString());
            }
            else
            {
                return -1;
            }
        }

        /// <summary>
        /// Delete Exam 
        /// </summary>
        /// <param name="examID"></param>
        /// <returns></returns>
        public static int DeleteExam(int examID)
        {
            string sSql = "DELETE FROM Exam WHERE ExamID = " + examID + ";";
            int rowsaffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsaffected;
        }

        /// <summary>
        /// Get all the exams of specific teacher
        /// </summary>
        /// <param name="teacherID"></param>
        /// <returns></returns>
        public static DataTable GetExamByTeacher(int teacherID)
        {
            string sSql = "SELECT * FROM Exam WHERE TeacherID = " + teacherID + ";";
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
    }
}
