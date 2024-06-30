using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using System.Data;

namespace BL_Project
{
    public class TeachersBL
    {
        private string teacherName;
        private string teacherEmail;
        private int teacherGender;
        private int TeacherID;


        public TeachersBL()
        {
        }

        public TeachersBL(string teacherName, string teacherEmail, int teacherGender, int teacherID)
        {
            this.teacherName = teacherName;
            this.teacherEmail = teacherEmail;
            this.teacherGender = teacherGender;
            this.TeacherID = teacherID;
        }
        /// <summary>
        /// Get this teacher ID
        /// </summary>
        /// <returns></returns>
        public int GetTeacherId()
        {
            return this.TeacherID;
        }

        /// <summary>
        /// Get this teacher first name
        /// </summary>
        /// <returns></returns>
        public string GetTeacherName()
        {
            return this.teacherName;
        }
        

        /// <summary>
        /// If the exercise doesn't already exist, it will add a new exercise
        /// </summary>
        /// <param name="path"></param>
        /// <param name="subjectID"></param>
        /// <param name="diff"></param>
        /// <param name="res"></param>
        /// <returns></returns>
        public int AddExercise(string path, int subjectID, int diff, string res)
        {
            if (!Exercise.IsExist(path))
            {
                return Exercise.InsertExercise(path, subjectID, diff, res, this.TeacherID);
            }
            return 0;
        }


        /// <summary>
        /// checks if the given exam already exists (by his name) if not it will Add exam
        /// </summary>
        /// <param name="examname"></param>
        /// <param name="exercises"></param>
        /// <returns></returns>
        public int AddExam(string examname, List<ExercisesBL> exercises, DateTime dateT, string examRules) 
        {
            if (!Exam.IsExist(examname) && exercises.Count >0)
            {
                string date = dateT.ToString("dd:MM:yyyy");
                Exam.InsertExam(date, examname, this.TeacherID, examRules);
                int id = Exam.GetExamIdByName(examname);
                foreach (ExercisesBL ex in exercises){
                    ExamExExercises.InsertExam(id, ex.GetExid()); //Insert all the exercises into ExamExExercises
                }
                return 1;
            }
            return 0;
        }
        /// <summary>
        /// Get stats of exercise
        /// </summary>
        /// <param name="examid"></param>
        /// <param name="exid"></param>
        /// <returns>
        /// </returns>
        public TeacherExStats GetStatsOfEx(int examid, int exid, int classId)
        {
            double r1, r2, r3, r4, r5;
            r1 = Answers.GetExStats(exid);
            r2 = Answers.GetExStatsOfTeacher(exid, this.TeacherID);
            r3 = Answers.GetStatsOfExInExam(exid, examid);
            r4 = Answers.GetAvgOfExamByTeacher(examid, this.TeacherID);
            r5 = Answers.GetStatsOfExInClass(exid, examid, classId);
            return new TeacherExStats(r1,r2,r3, r4, r5);
        }
        /// <summary>
        /// Get list of exercises that was created by the teacher
        /// </summary>
        /// <returns></returns>
        public List<ExercisesBL> GetTeacherEx()
        {
            List<ExercisesBL> l = new List<ExercisesBL>();
            DataTable dt = Exercise.GetExByCreator(this.TeacherID);
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
                l.Add(new ExercisesBL(exercisePath, subject, diff, AnswerRes, CreatorID, exid,Answers.GetExStats(exid)));
            }
            return l;
        }
        /// <summary>
        /// Delete exercise
        /// </summary>
        /// <param name="exid"></param>
        /// <returns></returns>
        public int DeleteExercise(int exid)
        {
            return Exercise.DeleteEx(exid);
        }
        /// <summary>
        /// Get Exams created by the teacher
        /// </summary>
        /// <returns></returns>
        public List<ExamBL> GetTeacherExams()
        {
            DataTable dt = Exam.GetExamByTeacher(this.TeacherID);
            string examDate;
            string examName;
            int examID;
            string examRules;
            List<ExamBL> l = new List<ExamBL>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                examDate = dt.Rows[i]["ExamDate"].ToString();
                examName = dt.Rows[i]["ExamName"].ToString();
                examID = int.Parse(dt.Rows[i]["ExamID"].ToString());
                examRules = dt.Rows[i]["ExamRules"].ToString();
                l.Add(new ExamBL(examID, examName, this.TeacherID, examDate, examRules));
            }
            return l;
        }
        /// <summary>
        /// Delete exam
        /// </summary>
        /// <param name="examid"></param>
        /// <returns></returns>
        public int DeleteExam(int examid)
        {
            return Exam.DeleteExam(examid);
        }
        /// <summary>
        /// Update exam date
        /// </summary>
        /// <param name="examid"></param>
        /// <param name="newDate"></param>
        /// <returns></returns>
        public int UpdateExamDate(int examid, string newDate)
        {
            return Exam.UpdateExamDate(newDate, examid);
        }
        /// <summary>
        /// Get all the classes of the teacher
        /// </summary>
        /// <returns></returns>
        public List<string> GetClassNames()
        {
            DataTable dt = Classes.GetClassesByTeacher(this.TeacherID);
            List<string> l = new List<string>();
            string className;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                className = dt.Rows[i]["ClassName"].ToString();
                l.Add(className);
            }
            return l;
        }
        /// <summary>
        /// Insert a grade for specific student in specific exercise
        /// </summary>
        /// <param name="student"></param>
        /// <param name="examID"></param>
        /// <param name="exerciseID"></param>
        /// <param name="grade"></param>
        /// <returns></returns>
        public int AddGradeForStudentInEx(StudentsBL student, int examID, int exerciseID, int grade)
        {
            if (grade >= 0 && grade <= 100 )
            {
                return Answers.InsertAnswer(grade, student.GetStudentID(), examID, exerciseID);
            }
            return 0;
        }
        /// <summary>
        /// Update the grade for specific student in specific exercise
        /// </summary>
        /// <param name="student"></param>
        /// <param name="examID"></param>
        /// <param name="exerciseID"></param>
        /// <param name="grade"></param>
        /// <returns></returns>
        public int UpdateGradeForStudentInEx(StudentsBL student, int examID, int exerciseID, int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                return Answers.UpdateAnswerResult(grade, examID, exerciseID, student.GetStudentID());
            }
            return 0;
        }
        /// <summary>
        /// Get the grade of the student in specific exam in specific exercise
        /// </summary>
        /// <param name="student"></param>
        /// <param name="examID"></param>
        /// <param name="exerciseID"></param>
        /// <returns></returns>
        public int GetGradeOfStudentInEx(StudentsBL student, int examID, int exerciseID)
        {
            return Answers.GetGradeInEx(student.GetStudentID(), examID, exerciseID);
        }
        /// <summary>
        /// Check if the current combination of student, exam and exercise already exists and updata/insert the grade.
        /// </summary>
        /// <param name="student"></param>
        /// <param name="examID"></param>
        /// <param name="exerciseID"></param>
        /// <param name="grade"></param>
        /// <returns></returns>
        public int InsertGradeforStudentInEx(StudentsBL student, int examID, int exerciseID, int grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                if (Answers.IsExist(student.GetStudentID(), examID, exerciseID) ==1)
                {
                    return UpdateGradeForStudentInEx(student, examID, exerciseID, grade);
                }
                return AddGradeForStudentInEx(student, examID, exerciseID, grade);
            }
            return 0;
        }
        /// <summary>
        /// Get exercises matching the student's diff and a sub he chose
        /// </summary>
        /// <param name="sub"></param>
        /// <returns></returns>
        public List<ExercisesBL> GetExBySub(int sub)
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
                return l;
            }
            return null;
        }
        /// <summary>
        /// Get's the Class ID by the Class Name
        /// </summary>
        /// <param name="className"></param>
        /// <returns></returns>
        public int GetClassIdByName(string className)
        {
            return Classes.GetClassIDByName(className);
        }
    }
}
