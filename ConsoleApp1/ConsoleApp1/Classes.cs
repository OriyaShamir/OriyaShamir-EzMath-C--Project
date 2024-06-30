using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp1
{
    public class Classes
    {
        /// <summary>
        /// Insert new class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="teacherID"></param>
        /// <returns>
        /// 1 on success
        /// 0 on failure
        /// </returns>
        public static int InsertClass(string name, int teacherID)
        {
            string sSql = "INSERT INTO Classses (ClassName, TeacherID) VALUES ('" + name + "', " + teacherID + ");";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }

        /// <summary>
        /// Get all the classes of specific teacher
        /// </summary>
        /// <param name="teacherID"></param>
        /// <returns>
        /// Classes on success
        /// null on failure
        /// </returns>
        public static DataTable GetClassesByTeacher(int teacherID)
        {
            string sSql = "SELECT * FROM Classes WHERE TeacherID = " + teacherID + ";";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt ==null || dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }


        /// <summary>
        /// Get Class Id By it's name
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public static int GetClassIDByName(string className)
        {
            string sSql = "SELECT * FROM Classes WHERE ClassName = '" + className + "';";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt == null || dt.Rows.Count == 0)
            {
                return -1;
            }
            return int.Parse(dt.Rows[0]["ClassID"].ToString());
        }

        /// <summary>
        /// Get's all the program classes
        /// </summary>
        /// <returns></returns>
        public static DataTable GetAllClasses()
        {
            string sSql = "SELECT * FROM Classes;";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }
    }
}
