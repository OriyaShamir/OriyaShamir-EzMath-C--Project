using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using System.Data;

namespace BL_Project
{
    public class StudentsBL
    {
        private string studentName;
        private int studentDiff;
        private int studentGender;
        private int studentID;
        private string password;
        private string username;
        private int classID;   
        public StudentsBL()
        {
        }
        /// <summary>
        /// Create Student object with a list of students and their class
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="studentName"></param>
        /// <param name="studentDiff"></param>
        /// <param name="studentGender"></param>
        /// <param name="password"></param>
        /// <param name="username"></param>
        /// <param name="classID"></param>
        public StudentsBL(int studentID, string studentName,int studentDiff, int studentGender, string password, string username, int classID)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.studentDiff = studentDiff;
            this.studentGender = studentGender;
            this.password = password;
            this.username = username;
            this.classID = classID;
        }
        /// <summary>
        /// Insert's the current student info
        /// </summary>
        /// <param name="id"></param>
        public StudentsBL(int id)
        {
            DataTable dt = Students.GetUserData(id); // Get's student Info
            if (dt != null && dt.Rows.Count > 0)
            {
                this.studentName = dt.Rows[0]["StudentName"].ToString();
                this.studentDiff = int.Parse(dt.Rows[0]["StudentDiff"].ToString());
                this.studentGender = int.Parse(dt.Rows[0]["StudentGender"].ToString());
                this.studentID = int.Parse(dt.Rows[0]["StudentID"].ToString());
                this.classID = int.Parse(dt.Rows[0]["ClassID"].ToString());
                this.password = dt.Rows[0]["StudentPassword"].ToString();
                this.username = dt.Rows[0]["StudentUsername"].ToString();
            }
        }
        
        /// <summary>
        /// Set username 
        /// </summary>
        /// <param name="name"></param>
        public void SetUsername(string name)
        {
            this.username = name;
        }
        /// <summary>
        /// Set name
        /// </summary>
        /// <param name="name"></param>
        public void SetName(string name)
        {
            this.studentName = name;
        }
        /// <summary>
        /// Set gender
        /// </summary>
        /// <param name="gne"></param>
        public void SetGender(int gne)
        {
            this.studentGender = gne;
        }
        /// <summary>
        /// Set difficulty
        /// </summary>
        /// <param name="diff"></param>
        public void SetDiff(int diff)
        {
            this.studentDiff = diff;
        }
        /// <summary>
        /// Get name
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return this.studentName;
        }
        /// <summary>
        /// Get username
        /// </summary>
        /// <returns></returns>
        public string GetUserName()
        {
            return this.username;
        }
        /// <summary>
        /// Get gender
        /// </summary>
        /// <returns></returns>
        public int GetGender()
        {
            return this.studentGender;
        }
        /// <summary>
        /// Get difficulty
        /// </summary>
        /// <returns></returns>
        public int GetDiff()
        {
            return this.studentDiff;
        }
        // <summary>
        // Check if the given student already voted. If he did update his vote according to liked parameter. Else:
        // If he already clicked Like or Dislike and he clicks again, It will delete their vote (Like or dislike)
        // Like or Dislike an exercise, if liked = YES ==> like, if liked = NO ==> dislike.       
        // </summary>
        // <param name="exid"></param>
        // <param name="like"></param>
        // <returns></returns>
        public int like(int exid, bool like)
        {
            int vot = Likes.Voted(this.studentID, exid);
            if (vot != 0)
            {
                if ((vot == 1 && like == true) || (vot == -1 && like == false))
                {
                    Exercise.UpdateExerciseScore(exid, false); //decrement score by 1
                    Likes.DeleteRecord(this.studentID, exid);
                    return -1;
                }
                else
                {
                    Exercise.UpdateExerciseScore(exid, like);//decrement/increment score by 1
                    Likes.UpdateLikes(this.studentID, exid, like);
                    return 0;
                }
            }
            else
            {
                Exercise.UpdateExerciseScore(exid, like);//decrement/increment score by 1
                Likes.Insertlike(this.studentID, exid, like);
                return 1;
            }
        }
        /// <summary>
        /// Return's Student Information by his UserName
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
        public StudentsBL GetStudentByName(string username)
        {
            DataTable dt = Students.GetUserDataByUsername(username);
            StudentsBL tempstudent = new StudentsBL();
            tempstudent.SetUsername(username);
            tempstudent.SetName(dt.Rows[0]["StudentName"] + "");
            tempstudent.SetGender(int.Parse(dt.Rows[0]["StudentGender"].ToString()));
            tempstudent.SetDiff(int.Parse(dt.Rows[0]["StudentDiff"].ToString()));
            return tempstudent;
        }
        /// <summary>
        /// Get exercises matching the student's difficulty
        /// </summary>
        /// <returns></returns>
        public List<ExercisesBL> getExForStudent()
        {
            DataTable dt = Exercise.GetExByDiff(this.studentDiff);
            List<ExercisesBL> l = new List<ExercisesBL>();
            string exercisePath;
            int subject;
            int diff;
            int exid;
            string AnswerRes;
            int CreatorID;
            for (int i=0; i< dt.Rows.Count; i++)
            {
                exercisePath = dt.Rows[i]["ExercisePath"].ToString();
                subject = int.Parse(dt.Rows[i]["SubjectID"].ToString());
                diff = int.Parse(dt.Rows[i]["Difficulty"].ToString());
                AnswerRes = dt.Rows[i]["AnswerRes"].ToString();
                exid = int.Parse(dt.Rows[i]["ExerciseID"].ToString());
                CreatorID = int.Parse(dt.Rows[i]["CreatorID"].ToString());
                l.Add(new ExercisesBL(exercisePath, subject, diff, AnswerRes, CreatorID, exid, Answers.GetExStats(exid)));
            }
            return l;
    }
        /// <summary>
        /// Get exercises matching the student's diff and a sub he chose
        /// </summary>
        /// <param name="sub"></param>
        /// <returns></returns>
        public List<ExercisesBL> getExForStudentBySub(int sub)
        {
            DataTable dt = Exercise.GetExPathsByDiffAndSub(this.studentDiff, sub);
            List<ExercisesBL> l = new List<ExercisesBL>();
            string exercisePath;
            int subject;
            int diff;
            int exid;
            string AnswerRes;
            int CreatorID;
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
            return l;
        }
        /// <summary>
        /// Get's the Exercises for the student by the selected subject and by his difficulty Ordered by likes
        /// </summary>
        /// <param name="sub"></param>
        /// <returns></returns>
        public List<ExercisesBL> getExForStudentBySubOrdered(int sub)
        {
            DataTable dt = Exercise.GetExBySubAndDiffOrdered(sub, this.studentDiff);
            if (dt != null)
            {
                List<ExercisesBL> l = new List<ExercisesBL>();
                string exercisePath;
                int subject;
                int diff;
                int exid;
                string AnswerRes;
                int CreatorID;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    exercisePath = dt.Rows[i]["ExercisePath"].ToString();
                    subject = sub;
                    diff = this.studentDiff;
                    AnswerRes = dt.Rows[i]["AnswerRes"].ToString();
                    exid = int.Parse(dt.Rows[i]["ExerciseID"].ToString());
                    CreatorID = int.Parse(dt.Rows[i]["CreatorID"].ToString());
                    l.Add(new ExercisesBL(exercisePath, subject, diff, AnswerRes, CreatorID, exid, Answers.GetExStats(exid)));
                }
                return l;
            }
            return null;
        }
        /// <summary>
        /// Get the student grade in specific exam
        /// </summary>
        /// <param name="examid"></param>
        /// <returns></returns>
        public double getGrade(int examid)
        {
            return Answers.GetGrade(examid, this.studentID);
        }
        /// <summary>
        /// Get list of the exam's excersices and their grades for the corresponding student
        /// </summary>
        /// <param name="examid"></param>
        /// <returns>
        /// List of StudentGrade objects
        /// </returns>
        public List<StudentGrade> getExGradesOfExam(int examid)
        {
            int id;
            string path;
            double grade;
            DataTable dt = Answers.GetExamAnswersByStudent(this.studentID, examid);
            List<StudentGrade> l = new List<StudentGrade>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                id = int.Parse(dt.Rows[i]["ExerciseID"].ToString());
                path = dt.Rows[i]["ExercisePath"].ToString();
                grade = double.Parse(dt.Rows[i]["AnswerRes"].ToString());
                l.Add(new StudentGrade(path, id, grade));
            }
            return l;
        }
        /// <summary>
        /// Return a dicitonary describes all the exams the student has taken
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, int> GetStudentExams()
        {
            DataTable dt = Answers.GetStudentExams(this.studentID);
            if (dt == null || dt.Rows.Count == 0)
            {
                return null;
            }
            Dictionary<string, int> result = new Dictionary<string, int>();
            string examName;
            int examID;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                examName = dt.Rows[i]["ExamName"].ToString();
                examID = int.Parse(dt.Rows[i]["ExamID"].ToString());
                result.Add(examName, examID);
            }
            return result;
        }
        /// <summary>
        /// Get the student's name
        /// </summary>
        /// <param name="studentName"></param>
        /// <returns></returns>
        public string GetstudentName()
        {
            return studentName;
        }
       
        /// <summary>
        /// Get the student difficulty level
        /// </summary>
        /// <param name="studentDiff"></param>
        /// <returns></returns>
        public string GetstudentDiff(string studentDiff)
        {
            return studentDiff;
        }
        /// <summary>
        /// Change password
        /// </summary>
        /// <param name="oldPass"></param>
        /// <param name="newPass"></param>
        public bool Changepass(string oldPass, string newPass)
        {
            if (oldPass.Equals(this.password))
            {
                Students.UpdatePassword(this.username, newPass);
                return true;
            }
            else
            {
                return false;
            }
        }  
        /// <summary>
        /// Get student ID
        /// </summary>
        /// <returns></returns>
        public int GetStudentID()
        {
            return this.studentID;
        }
        /// <summary>
        /// change student difficulty
        /// </summary>
        /// <param name="diff"></param>
        /// <returns></returns>
        public bool changeDiff(int diff)
        {
            return (Students.UpdateDifficullty(this.username, diff) == 1);
        }
    }
}
