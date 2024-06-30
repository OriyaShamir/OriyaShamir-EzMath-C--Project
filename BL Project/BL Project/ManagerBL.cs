using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using System.Data;

namespace BL_Project
{
    public class ManagerBL
    {
        /// <summary>
        /// Inserts a new teacher to the system
        /// </summary>
        /// <param name="teacheruserName"></param>
        /// <param name="teacherpassword"></param>
        /// <param name="teacheremail"></param>
        /// <param name="teachergender"></param>
        /// <param name="teachername"></param>
        public void InsertTeacher(string teacheruserName, string teacherpassword, string teacheremail, int teachergender, string teachername)
        {
            if (Teachers.IsUserExist(teacheruserName) == 0)
            {
                Teachers.InsertTeacher(teacheruserName, teacherpassword, teacheremail, teachergender, teachername);
            }
        }
        /// <summary>
        /// Verify the teacher
        /// </summary>
        /// <param name="teacheruserName"></param>
        public void Verify(string teacheruserName)
        {
            Teachers.Verify(teacheruserName);
        }
        /// <summary>
        /// Check if the username and password are correct. if so create new instance to Teacher with the relevant data
        /// </summary>
        /// <param name="username"></param>
        /// <param name="pass"></param>
        /// <returns></returns>
        public TeachersBL AuthTeacher(string username, string pass)
        {
            int id;
            if (Teachers.IsUserExist(username) == 1) // 1 = verified
            {
                if ((id =Teachers.Auth(username, pass)) != -1) // correct username and password
                {
                    DataTable dt = Teachers.GetUserData(id);
                    string teacherName = dt.Rows[0]["TeacherName"].ToString();
                    string teacherEmail = dt.Rows[0]["TeacherEmail"].ToString();
                    int teacherGender = int.Parse(dt.Rows[0]["TeacherGender"].ToString());
                    int teacherID = int.Parse(dt.Rows[0]["TeacherID"].ToString());
                    return new TeachersBL(teacherName, teacherEmail, teacherGender, teacherID);
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
        /// <summary>
        /// Register a new student
        /// </summary>
        /// <param name="stuserName"></param>
        /// <param name="stpassword"></param>
        /// <param name="stemail"></param>
        /// <param name="stgender"></param>
        /// <param name="stname"></param>
        public bool InsertStudent(string stuserName, string stpassword, string stemail, int stgender, string stname, int classID, int diff)
        {
            int a = 0;
            if (!Students.IsUserExist(stuserName))
            {
                a = Students.InsertStudent(stuserName, stpassword, stemail, stgender, stname, classID, diff);
            }
            if (a > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Check if the username and password are correct. if so create new instance to Student with the relevant data
        /// </summary>
        /// <param name="uname"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public StudentsBL AuthStudent(string uname, string password)
        {
            int id;
            if ((id = Students.Auth(uname, password)) != -1) // correct username and password
            {
                DataTable dt = Students.GetUserData(id);
                string studentName = dt.Rows[0]["StudentName"].ToString();
                int studentDiff = int.Parse(dt.Rows[0]["StudentDiff"].ToString());
                int studentGender = int.Parse(dt.Rows[0]["StudentGender"].ToString());
                int studentID = int.Parse(dt.Rows[0]["StudentID"].ToString());
                int classID = int.Parse(dt.Rows[0]["ClassID"].ToString());
                return new StudentsBL(studentID, studentName, studentDiff, studentGender, password, uname, classID);
            }
            else
            {
                 return null;
            }
        }
        /// <summary>
        /// Get All classes Names and ID in a list
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetClassNames()
        {
            DataTable dt = Classes.GetAllClasses();
            Dictionary<string, int> l = new Dictionary<string, int>();
            string className;
            int classId;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                className = dt.Rows[i]["ClassName"].ToString();
                classId = int.Parse(dt.Rows[i]["ClassID"].ToString());
                l.Add(className, classId);
            }
            return l;
        }
        /// <summary>
        /// Get a list of all subjects names
        /// </summary>
        /// <returns></returns>
        public List<string> GetAllSubjectNames()
        {
            DataTable dt = Subjects.GetAllSubjects();
            List<string> l = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                l.Add(dt.Rows[i]["SubjectText"].ToString());
            }
            return l;
        }
        /// <summary>
        /// Gets a list of all subjects
        /// </summary>
        /// <returns></returns>
        public List<SubjectsBL> GetAllSubjects()
        {
            string text;
            int id;
            DataTable dt = Subjects.GetAllSubjects();
            List< SubjectsBL> l = new List<SubjectsBL>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                text = dt.Rows[i]["SubjectText"] + "";
                id = int.Parse(dt.Rows[i]["SubjectID"] + "");

                l.Add(new SubjectsBL(text, id));
            }
            return l;
        }
        /// <summary>
        /// Insert new subject
        /// </summary>
        /// <param name="subjectText"></param>
        /// <returns></returns>
        public int InsertSubject(string subjectText)
        {
            if (!Subjects.IsExist(subjectText))
            {
                return Subjects.InsertSubject(subjectText);
            }
            return -1;
        }
        /// <summary>
        /// Delete subject
        /// </summary>
        /// <param name="subjectText"></param>
        /// <returns></returns>
        public int DeleteSubject(string subjectText)
        {
            return Subjects.DeleteSubject(subjectText);
        }
        /// <summary>
        /// Get Sub ID by it's text
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public int GetSubByText(string text)
        {
            return Subjects.GetSubID(text);
        }
        /// <summary>
        /// Get 3 best exercises matching the subject Ordered by Best satistics
        /// </summary>
        /// <param name="sub"></param>
        /// <returns></returns>
        public List<ExercisesBL> GetOrderedByStatsExBySub(int sub)
        {
            DataTable dt = Exercise.GetExBySub(sub);
            List<ExercisesBL> l = new List<ExercisesBL>(), r = new List<ExercisesBL>();
            string exercisePath;
            int subject;
            int diff;
            int exid;
            string AnswerRes;
            int CreatorID;
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    exercisePath = dt.Rows[i]["ExercisePath"].ToString();
                    subject = int.Parse(dt.Rows[i]["SubjectID"].ToString());
                    diff = int.Parse(dt.Rows[i]["Difficulty"].ToString());
                    AnswerRes = dt.Rows[i]["AnswerRes"].ToString();
                    exid = int.Parse(dt.Rows[i]["ExerciseID"].ToString());
                    CreatorID = int.Parse(dt.Rows[i]["CreatorID"].ToString());
                    l.Add(new ExercisesBL(exercisePath, subject, diff, AnswerRes, CreatorID, exid, Answers.GetExStats(exid)));
                }
                l.Sort((ex1, ex2) => ex1.GetExAvg().CompareTo(ex2.GetExAvg()));// Sort's exercises by average stats
                l.Reverse();
                for (int i = 0; i < l.Count && i<3; i++) //select top 3 (or less) exercises 
                {
                    r.Add(l[i]);
                }
                return r;
            }
            return null;
        }
        /// <summary>
        /// Get exercises matching the subject Ordered by Best satistics
        /// </summary>
        /// <param name="sub"></param>
        /// <returns></returns>
        public List<ExercisesBL> GetAllOrderedByStatsExBySub(int sub)
        {
            DataTable dt = Exercise.GetExBySub(sub);
            List<ExercisesBL> l = new List<ExercisesBL>();
            string exercisePath;
            int subject;
            int diff;
            int exid;
            string AnswerRes;
            int CreatorID;
            if (dt != null)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    exercisePath = dt.Rows[i]["ExercisePath"].ToString();
                    subject = int.Parse(dt.Rows[i]["SubjectID"].ToString());
                    diff = int.Parse(dt.Rows[i]["Difficulty"].ToString());
                    AnswerRes = dt.Rows[i]["AnswerRes"].ToString();
                    exid = int.Parse(dt.Rows[i]["ExerciseID"].ToString());
                    CreatorID = int.Parse(dt.Rows[i]["CreatorID"].ToString());
                    l.Add(new ExercisesBL(exercisePath, subject, diff, AnswerRes, CreatorID, exid, Answers.GetExStats(exid)));
                }
                l.Sort((ex1, ex2) => ex1.GetExAvg().CompareTo(ex2.GetExAvg()));// Sort's exercises by average stats
                l.Reverse();
                return l;
            }
            return null;
        }
        /// <summary>
        /// return's subject ID
        /// </summary>
        /// <param name="subjectName"></param>
        /// <returns></returns>
        public int GetSubjectID(string subjectName)
        {
            return Subjects.GetSubID(subjectName);
        }
        /// <summary>
        /// Show's All the Exam Exercises path (picture)
        /// </summary>
        /// <param name="examid"></param>
        /// <returns></returns>
        public DataTable GetExamExercises(int examid)
        {
            return ExamExExercises.GetExamExercises(examid);
        }
        /// <summary>
        /// Get The exam id by the exam name
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public int GetExamID(string name)
        {
           return Exam.GetExamIdByName(name);
        }
        /// <summary>
        /// get the exam name by the exam id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public DataTable GetExamById(int id)
        {
           return Exam.GetExamById(id);
        }
        

    }
}
