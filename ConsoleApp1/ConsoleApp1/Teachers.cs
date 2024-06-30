using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp1
{
     public class Teachers
    {
        /// <summary>
        /// Insert Teacher
        /// Insert Teacher username,password,email,gender and first name
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="gender"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public int InsertTeacher(string teacheruserName, string teacherpassword, string teacheremail, int teachergender, string teachername)
        {
            string sSql = "INSERT INTO tblTeachers (TeacherUsername,TeacherPassword,TeacherEmail,TeacherGender, TeacherName, Verified) " +
                                "VALUES ('" + teacheruserName + "','" + teacherpassword + "','" + teacheremail + "'," + teachergender + ", '" + teachername + "', false )";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }

        /// <summary>
        /// Check's if the teacher already exsits and if he is verfied or not
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns>
        /// 0 if not exist
        /// 1 if verified
        /// -1 if not verified
        /// </returns>
        static public int IsUserExist(string teacheruserName)
        {
            string sSql = "SELECT Verified " +
                                "FROM tblTeachers " +
                                "WHERE TeacherUsername = '" + teacheruserName + "';";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null && dt.Rows.Count > 0)
            {
                bool v = (bool)dt.Rows[0]["Verified"];
                if (v == true)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return 0;
            }
        }

        /// <summary>
        /// Update the teacher to be verifed by his username
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        static public int Verify(string teacheruserName)
        {
            string sSql = "UPDATE tblTeachers Set [Verified] = true Where TeacherUsername = '" + teacheruserName + "'";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }

        /// <summary>
        /// Gets Teacher Info by his id
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public DataTable GetUserData(int teacherID)
        {
            string sSql = "SELECT * " +
                                "FROM tblTeachers " +
                                "WHERE TeacherID = " + teacherID+ ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }

        /// <summary>
        /// Check's if the teacher's password and username is correct
        /// </summary>
        /// <param name="usr"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        static public int Auth(string usr, string pass)
        {
            string sSql= "SELECT TeacherID FROM tblTeachers WHERE TeacherUsername='"+usr+ "' AND TeacherPassword = '"+pass+"'";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt == null || dt.Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                return int.Parse(dt.Rows[0]["TeacherID"].ToString());
            }
        }
    }
}
