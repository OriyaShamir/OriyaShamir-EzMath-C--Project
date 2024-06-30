using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp1
{
   public class ExamStudent
    {
        /// <summary>
        /// gets the teacher name by the exam ID
        /// </summary>
        /// <returns></returns>
         static public DataTable GetTeacherNameByExam() 
        {
            string sSql = "SELECT ExamStudent.ExamID, tblTeachers.TeacherName " +
                                "FROM ExamStudent " +
                                "INNER JOIN tblTeachers ON ExamStudent.TeacherID = tblTeachers.TeacherID;";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }


        /// <summary>
        /// מכניס את מזהה התלמיד, מזהה המבחן, מזהה והמורה ואת התשובות לשאלות
        /// לכל שאלה יש ניקוד משלה
        /// </summary>
        /// <param name="studentId"></param>
        /// <param name="ExamId"></param>
        /// <param name="teacherId"></param>
        /// <param name="grades"></param>
        /// <returns></returns>                                             //
        static public int InsertExamStudent(int studentId, int ExamId, int teacherId, string examdate)
        {
            string sSql = "INSERT INTO ExamStudent (StudentID,ExamID, TeacherID, ExamDate) " +
                                "VALUES ('" + studentId + "'," + ExamId + "," +teacherId+", '"+examdate+"')";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }
        /// <summary>
        /// מעדכן את התאריך שהמבחן בוצע בו
        /// </summary>
        /// <param name="examDate"></param>
        /// <param name="examID"></param>
        /// <returns></returns>
        static public int UpdateExamDate(DateTime examDate, int examID)
        {
            string sSql = "UPDATE ExamStudent SET ExamDate =#" +
                        examDate + "# WHERE ExamID = " + examID + ";";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }

        /// <summary>
        /// מחזיר את נתוני התלמיד שעשה מבחן לפי האיידי של המבחן
        /// </summary>
        /// <param name="examid"></param>
        /// <returns></returns>
        static public DataTable GetStudentInfo(int examid)
        {
            string sSql = "SELECT tblStudents.* FROM ExamStudent INNER JOIN tblStudents ON ExamStudent.StudentID = tblStudents.StudentID WHERE ExamStudent.ExamStudentID =" + examid + ";";
            return DBHelper.GetDataTable(sSql);
        }
        /*
        /// <summary>
        /// מעדכן את ציוני המבחן של התלמיד 
        /// </summary>
        /// <param name="examGrade"></param>
        /// <param name="examID"></param>
        /// <returns></returns>
        static public int UpdateExamGrades(string examGrade, int examID)
        {
            string sSql = "UPDATE ExamStudent SET Grades ='" +
                        examGrade + "' WHERE ExamStudentID = " + examID + ";";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }
        */


        /// <summary>
        /// Get Exam by the student ID
        /// </summary>
        /// <param name="stID"></param>
        /// <returns></returns>
        public static DataTable GetExamByStudent(int stID)  // st = Student
        {
            string sSql = "SELECT * FROM ExamStudent WHERE StudentID = " + stID + ""; 
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }

        /// <summary>
        /// Get Exam by the exam ID
        /// </summary>
        /// <param name="ExamID"></param>
        /// <returns></returns>
        public static DataTable GetExamByExam(int ExamID) 
        {
            string sSql = "SELECT * FROM ExamStudent WHERE ExamID = " + ExamID + "";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }

        /// <summary>
        /// Get Exam by the teacher ID
        /// </summary>
        /// <param name="teacherID"></param>
        /// <returns></returns>
        public static DataTable GetExamByTeacher(int teacherID)
        {
            string sSql = "SELECT * FROM ExamStudent WHERE TeacherID = " + teacherID + "";
            DataTable dt = DBHelper.GetDataTable(sSql);
            return dt;
        }



        /// <summary>
        /// get exam grade by the exam Id and Student ID
        /// </summary>
        /// <param name="stID"></param>
        /// <param name="examID"></param>
        /// <returns></returns>
        /// 

           


            //////////////////////////////////////////////////////////////////////
       /* public static double getGrade(int stID, int examID)
        {
            string sSql = "SELECT * FROM ExamStudent WHERE ExamID = " + examID + " AND StudentID = "+ stID;
            DataTable dt = DBHelper.GetDataTable(sSql);
            if(dt.Rows.Count == 0)
            {
                return -1;
            }
            else
            {
                int size = Exam.getSizeByID(examID);
                string grades = dt.Rows[0]["Grades"].ToString();  //Get the Grades field of the specified input
                string[] g = grades.Split('_'); //Split the grades string to grades array
                int counter = 0;
                for (int i =1; i < size+1; i++)
                {
                    counter += int.Parse(g[i]); // Adds all the grades
                }
                return counter / size;
            }
        }
       */
    }
}
