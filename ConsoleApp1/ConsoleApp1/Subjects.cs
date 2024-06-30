using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp1
{
    public class Subjects
    {
        /// <summary>
        /// Get all the Subjects
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllSubjects()
        {
            string sSql = "SELECT * FROM tblSubjects";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt !=null && dt.Rows.Count != 0)
            {
                return dt;
            }
            return null;
        }
        /// <summary>
        /// Insert new subject
        /// </summary>
        /// <param name="subjectText"></param>
        /// <returns></returns>
        public static int InsertSubject(string subjectText)
        {
            string sSql = "INSERT INTO tblSubjects (SubjectText) " +
                                "VALUES ('" + subjectText + "');";     
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }
        /// <summary>
        /// Get subject by it's id
        /// </summary>
        /// <param name="subid"></param>
        /// <returns></returns>
        public static DataTable GetSubById(int subid)
        {
            string sSql = "SELECT * " +
                                "FROM tblSubjects " +
                                "WHERE SubjectID = " + subid + ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }
        /// <summary>
        /// Update subject text
        /// </summary>
        /// <param name="subjectText"></param>
        /// <param name="subjectID"></param>
        /// <returns></returns>
        static public int UpdateSubjectText(string old_subjectText, string new_subjectText)
        {
            string sSql = "UPDATE tblSubjects SET SubjectText ='" +
                        new_subjectText + "' WHERE SubjectText = '" + old_subjectText+ "';";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }

        /// <summary>
        /// בודק האם הנושא כבר קיים במערכת
        /// </summary>
        /// <param name="subjectText"></param>
        /// <returns></returns>
        static public bool IsExist(string subjectText)
        {
            string sSql = "SELECT * " +
                               "FROM tblSubjects " +
                               "WHERE SubjectText = '" + subjectText + "';";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt ==null || dt.Rows.Count == 0)
            {
                return false;
            }
            return true;

        }
        /// <summary>
        /// מחיקת נושא קיים
        /// </summary>
        /// <param name="subjectText"></param>
        /// <returns></returns>
        public static int DeleteSubject(string subjectText)
        {
            string sSql = "DELETE FROM tblSubjects WHERE SubjectText ='" + subjectText + "';";
            int rowsaffeced = DBHelper.ExecuteNonQuery(sSql);
            return rowsaffeced;
        }

        /// <summary>
        /// Get Subject ID by its text
        /// </summary>
        /// <param name="text"></param>
        /// <returns>
        /// 1 on failure
        /// ID otherwise
        /// </returns>
        public static int GetSubID(string text)
        {
            string sSql = "SELECT * FROM tblSubjects WHERE SubjectText = '" + text + "';";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt== null || dt.Rows.Count == 0)
            {
                return -1;
            }
            return int.Parse(dt.Rows[0]["SubjectID"].ToString());
        }
    }
}
