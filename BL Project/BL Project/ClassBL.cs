using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ConsoleApp1;
namespace BL_Project
{
    public class ClassBL
    {
        private int classID;
        private int teacherID;
        private List<StudentsBL> students;


        /// <summary>
        /// Create Class object with a list of students belongs to the class
        /// </summary>
        /// <param name="classID"></param>
        /// <param name="teacherID"></param>
        public ClassBL (int classID, int teacherID)
        {
            this.classID = classID;
            this.teacherID = teacherID;
            this.students = new List<StudentsBL>();
            DataTable dt = Students.GetStudentsByClass(classID);
            int studentID, studentDiff, studentGender;
            string password, username, studentName;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                 studentName = dt.Rows[i]["StudentName"].ToString();
                 studentDiff = int.Parse(dt.Rows[i]["StudentDiff"].ToString());
                 studentGender = int.Parse(dt.Rows[i]["StudentGender"].ToString());
                 studentID = int.Parse(dt.Rows[i]["StudentID"].ToString());
                 classID = int.Parse(dt.Rows[i]["ClassID"].ToString());
                 password = dt.Rows[i]["StudentPassword"].ToString();
                 username = dt.Rows[i]["StudentUsername"].ToString();
                 this.students.Add(new StudentsBL(studentID, studentName, studentDiff, studentGender, password, username, classID));
            }
        }
        /// <summary>
        /// Get's the classID by the ClassName
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static int GetClassId(string name)
        {
            return Classes.GetClassIDByName(name);
        }
        /// <summary>
        /// Get's the student's in the class
        /// </summary>
        /// <returns></returns>
        public List<StudentsBL> GetStudentsInClass()
        {
            return this.students;
        }
    }
}
