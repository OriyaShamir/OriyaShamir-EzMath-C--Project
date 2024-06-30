using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace ConsoleApp1
{
     public class Students
    {

        /// <summary>
        /// Get all the students in specific class
        /// </summary>
        /// <param name="classID"></param>
        /// <returns>
        /// Students on success
        /// null on failure
        /// </returns>
        public static DataTable GetStudentsByClass(int classID)
        {
            string sSql = " SELECT * FROM tblStudents WHERE ClassID = " + classID + ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt ==null || dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }


        ///// <summary>
        ///// Gets the student name by the student ID and his grades
        ///// </summary>
        ///// <param name="name"></param>
        ///// <returns></returns>
        static public DataTable GetNameByGradesAndId()
        {
            string sSql = "SELECT StudentName " +
                                "FROM ExamStudent " +
                                "INNER JOIN tblStudents ON ExamStudent.StudentID = tblStudents.StudentID;";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }

        /// <summary>
        /// gets the student Id by his name
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        static public int GetUserId(string stuserName)
        {
            string sSql = "SELECT StudentID " +
                                "FROM tblStudents " +
                                "WHERE StudentName = '" + stuserName + "';";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return int.Parse(dt.Rows[0][0] + "");
        }
        /// <summary>
        /// Insert Student
        /// Insert username,name,password,email,gender,classID, difficulty
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <param name="email"></param>
        /// <param name="gender"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        static public int InsertStudent(string stuserName, string stpassword, string stemail, int stgender, string stname, int classID, int diff) 
        {
            string sSql = "INSERT INTO tblStudents (StudentUsername,StudentPassword,StudentEmail,StudentGender, StudentName,StudentDiff, ClassID) " +
                                "VALUES ('" + stuserName + "','" + stpassword + "','" + stemail + "'," + stgender + ", '" + stname + "'," + diff +","+ classID+");";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }


        /// <summary>
        /// Update Student's Difficulty
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="difficullty"></param>
        /// <returns></returns>
        static public int UpdateDifficullty(string stuserName, int stdifficullty) 
        {
            string sSql = "UPDATE tblStudents SET [StudentDiff] =" +
                        stdifficullty + " WHERE StudentUsername = '" + stuserName + "'";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }


        /// <summary>
        /// Update's student password
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="newPass"></param>
        /// <returns></returns>
        static public int UpdatePassword(string stuserName, string newPass)
        {
            string sSql = "UPDATE tblStudents SET [StudentPassword] ='" +
                        newPass + "' WHERE StudentUsername = '" + stuserName + "'";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }


        /// <summary>
        /// check if the student already exsits
        /// </summary>
        /// <param name="userName"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public bool IsUserExist(string stuserName)
        {
            string sSql = "SELECT StudentUsername" +
                                " FROM tblStudents" +
                                " WHERE StudentUsername = '" + stuserName + "'";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null && dt.Rows.Count > 0) // 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Login check, checks if the student already exsits, if no - add him and if he does, check if his password is correct
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        static public bool LoginChecker(string username, string password)
        {
            if(!Students.IsUserExist(username))
            {
                return false;
            }

            string sSql = "SELECT * " +
                "FROM tblStudents " +
                "WHERE StudentUsername = '" + username + "'";
            DataTable dt = DBHelper.GetDataTable(sSql);

            if ((dt.Rows[0]["StudentPassword"] + "").Equals(password))
            {
                return true;
            }
            else
                return false;

        }

        /// <summary>
        /// Gets User Info
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        static public DataTable GetUserData(int studentId)
        {
            string sSql = "SELECT * " +
                                "FROM tblStudents " +
                                "WHERE StudentID = " + studentId + ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }

        /// <summary>
        /// Get User information by his username
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        static public DataTable GetUserDataByUsername(string username)
        {
            string sSql = "SELECT * " +
                                "FROM tblStudents " +
                                "WHERE StudentUsername = '" + username + "';";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }

        /// <summary>
        /// auth the studnet username and password
        /// </summary>
        /// <param name="usr"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        static public int Auth(string usr, string pass)
        {
            string sSql = "SELECT StudentID FROM tblStudents WHERE StudentUsername='" + usr + "' AND StudentPassword = '" + pass + "'";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt == null || dt.Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                return int.Parse(dt.Rows[0]["StudentID"].ToString());
            }
        }
    }
}
