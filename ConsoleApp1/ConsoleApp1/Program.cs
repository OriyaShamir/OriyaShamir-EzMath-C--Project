using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    class Program
    {
        static void CheckAnswers()
        {

            Console.WriteLine("\n\n______________________________________________________________________________");
           // ANSWERS CHECK
            Console.WriteLine("Answers Check:\n");
            Console.WriteLine("Insert: (AnswerRes = 15, StudentID=1, ExamID=54(exam that exist in examstudent), ExerciseID=2)" + Answers.InsertAnswer(15, 1, 54, 2));
            Console.WriteLine("getResById: (id=1) ");
            DataTable d1 = Answers.GetResById(1);
            for (int i = 0; i < d1.Rows.Count; i++)
            {
                for (int j = 0; j < d1.Columns.Count; j++)
                {
                    Console.Write(d1.Rows[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("UpdateAnswerResult: (id=1, value =13) " + Answers.UpdateAnswerResult(13, 1, 5, 6));
            Console.WriteLine("getExamAnswersByStudent: (StudentID=1, ExamID=3)");
            DataTable d2 = Answers.GetExamAnswersByStudent(1, 3);
            for (int i = 0; i < d2.Rows.Count; i++)
            {
                for (int j = 0; j < d2.Columns.Count; j++)
                {
                    Console.Write(d2.Rows[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("getExStats(2) " + Answers.GetExStats(2));
            Console.WriteLine("getExStatsOfTeacher(2,1)" + Answers.GetExStatsOfTeacher(2, 1));
            Console.WriteLine("getAvgOfExamByTeacher(3,1) " + Answers.GetAvgOfExamByTeacher(3, 1));
            Console.WriteLine("getStatsOfExInExam(2,3) " + Answers.GetStatsOfExInExam(2, 3));
        }

        static void CheckExam()
        {
            DataTable dt2;
            Console.WriteLine("\n\n______________________________________________________________________________");
          //  EXAM CHECK
            Console.WriteLine("Exam Check: \n");
            Console.WriteLine("Insert : (Date=20.11.2020, name=math3, teacherID=1) " + Exam.InsertExam(DateTime.Now.ToString("dd:MM:YYYY"), "math3", 1, ""));
            Console.WriteLine("UpdateExamDate: (ExamDate = 23.11.2020, ExamID=2) " + Exam.UpdateExamDate(DateTime.Now.ToString("dd:MM:YYYY"), 2));
            Console.WriteLine("getExamById: (ExamID=2) ");
            dt2 = Exam.GetExamById(2);
            for (int i = 0; i < dt2.Rows.Count; i++)
            {
                for (int j = 0; j < dt2.Columns.Count; j++)
                {
                    Console.Write(dt2.Rows[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void CheckExamExExercise()
        {
            //Console.WriteLine("\n\n______________________________________________________________________________");
            //Console.WriteLine("ExamExExercise Check: \n");
            //Console.WriteLine("Insert (ExamID = 2, ExerciseID = 8)"); ExamExExercises.Insertexam(2, 8);
            DataTable a = ExamExExercises.GetExamExercises(2);
            if (a == null)
            {
                Console.WriteLine("getExamExercises FAILED!!");
            }
            else
            {
                Console.WriteLine("getExamExercises (ExamID = 2): ");
                for (int i = 0; i < a.Rows.Count; i++)
                {
                    Console.WriteLine("\t " + i + ". " + a.Rows[i][0]);
                }
            }
            //string[] b = ExamExExercises.Getexamexercisestext(2);
            //if (b == null)
            //{
            //    Console.WriteLine("getExamExercisesText FAILED!!");
            //}
            //else
            //{
            //    Console.WriteLine("getExamExercisesText (ExamID = 2): ");
            //    for (int i = 0; i < b.Length; i++)
            //    {
            //        Console.WriteLine("\t " + i + ". " + b[i]);
            //    }
            //}
        }

        static void CheckExercise()
        {
            /*
            Console.WriteLine("\n\n______________________________________________________________________________");
            // EXERCISE CHECK
            Console.WriteLine("Exercise Check:\n");
            Console.WriteLine("Insert: (extext = 5*6, exsub = Multiplication, exdiff = exdiff, stat = 0, exanswerres = 30)" + Exercise.InsertExercise("/tmp/text.jpg", 1, 3, "30", 9));
            Console.WriteLine("UpdateExercisePath: (ExerciseText = 60*2, ExerciseID=3) " + Exercise.UpdateExercisePath("/tmp/text1.jpg", 3));
            Console.WriteLine("UpdateExerciseDiff: (ExerciseDiff = hard, ExerciseID=3) " + Exercise.UpdateExerciseDiff(4, 3));
            Console.WriteLine("UpdateExerciseSubject: (Exercise Subject = Division (2), ExerciseID=5) " + Exercise.UpdateExerciseSubject(2, 5));
            string d3 = Exercise.GetExercisePath(5);
            Console.WriteLine("GetExerciseData: (ExerciseID=5) " + d3);
            Console.WriteLine("getExByDiff: (exdiff=easy)");
            DataTable d4 = Exercise.GetExByDiff(3);
            for (int i = 0; i < d4.Rows.Count; i++)
            {
                Console.WriteLine((i+1)+". Ex id: " + d4.Rows[i][0] + "Ex path: " + d4.Rows[i][1]);
            }
            */
            Console.WriteLine("getExBySub: (exsub ID=1)");
            DataTable d5 = Exercise.GetExBySub(25);
            for (int i = 0; i < d5.Rows.Count; i++)
            {
                Console.WriteLine((i+1)+ ". Ex id: " + d5.Rows[i][0] + "Ex path: " + d5.Rows[i][1]);
            }
            Console.WriteLine("getExPathsByDiffAndSub (exsub ID= 1, exdiff=easy)");
            DataTable d6 = Exercise.GetExPathsByDiffAndSub(3,1);
            for (int i = 0; i < d6.Rows.Count; i++)
            {
                Console.WriteLine((i+1)+". Ex id: " + d6.Rows[i][0] + "Ex path: " + d6.Rows[i][1]);
            }
        }

        static void CheckStudent()
        {
            Console.WriteLine("\n\n______________________________________________________________________________");
            // STUDENTS CHECK
            Console.WriteLine("GetNameByGradesandID:");
            DataTable d7 = Students.GetNameByGradesAndId();
            for (int i = 0; i < d7.Rows.Count; i++)
            {
                for (int j = 0; j < d7.Columns.Count; j++)
                {
                    Console.Write(d7.Rows[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("GetUserID: (UserID=1) " + Students.GetUserId("Oriya"));
            Console.WriteLine("InsertStudent: (stusername = SirRayen stpassword = 5578, stemail = sirrayen@gmail.com, stgender = male, stname = shamirush) " + Students.InsertStudent("SirRayen", "5578", "sirrayen@gmail.com", 1, "shamirush", 0, 3));
            Console.WriteLine("UpdateDifficullty: (stusername = Oriya12, stdiff = hard) " + Students.UpdateDifficullty("Oriya12", 5));
            Console.WriteLine("IsUserExist: (stusername = Oriya12, stpassworrd = 12345) " + Students.IsUserExist("Oriya12"));
            Console.WriteLine("GetUserData: (stusername= Oriya12) " + Students.GetUserData(0));
        }

        static void CheckSubjects()
        {

            Console.WriteLine("\n\n______________________________________________________________________________");
            // SUBJECTS CHECK
            Console.WriteLine("InsertSubject: (Subject Text=Addition ) " + Subjects.InsertSubject("Addition"));
            Console.WriteLine("getsubById: (subid=2)");
            DataTable d8 = Subjects.GetSubById(2);
            for (int i = 0; i < d8.Rows.Count; i++)
            {
                for (int j = 0; j < d8.Columns.Count; j++)
                {
                    Console.Write(d8.Rows[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("UpdateSubjectText;': (Subject Text=Division, SubjectID = 5 ) " + Subjects.UpdateSubjectText("Division", "Multiplication"));
            Console.WriteLine("GetAllSubjects():");
            DataTable subjects = Subjects.GetAllSubjects();
            for (int i = 0; i < subjects.Rows.Count; i++)
            {
                Console.WriteLine((i+1)+". "+subjects.Rows[i][0]);
            }
        }

        static void CheckTeachers()
        {
            Console.WriteLine("\n\n______________________________________________________________________________");
            // TEACHERS CHECK
            Console.WriteLine("InsertTeacher: (TeacherUsername = Dor, TeacherPassword = 8945, TeacherMail = dortal93@gmail.com TeacherGender = Male, TeacherName = Dor Tal) " + Teachers.InsertTeacher("Dor", "8945", "dortal93@gmail.com",1, "Dor Tal"));
            Console.WriteLine("IsUserExist: (TeacherUserName = SHay5, TeacherPassword= 23456 ) " + Teachers.IsUserExist("SHay5"));
            Console.WriteLine("Verify: (TeacherUserName = shamir) " + Teachers.Verify("shamir"));
            Console.WriteLine("GetUserData: (TeacherUsername = Oriya, TeacherPassword=1234321");
            DataTable d9 = Teachers.GetUserData(0);
            for (int i = 0; i < d9.Rows.Count; i++)
            {
                for (int j = 0; j < d9.Columns.Count; j++)
                {
                    Console.Write(d9.Rows[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
        static void CheckLikes()
        {
            Console.WriteLine("\n\n______________________________________________________________________________");
            Console.WriteLine("New like (ExId = 2, StudentID = 1) " + Likes.Insertlike(1, 2, true));
            Console.WriteLine("Voted (ExID=1, studentID =1 " + Likes.Voted(1, 2));
            Console.WriteLine("Turn to dislike " + Likes.Insertlike(1, 2, false));
            Console.WriteLine("Unvote" + Likes.Insertlike(1, 2, false));
            Likes.Insertlike(1, 2, true);
            Likes.Insertlike(2, 2, true);
            Console.WriteLine("Total likes (ExId = 1): " + Likes.GetLikesForEx(1));
        }
        static void Main(string[] args)
        {
            //CheckExamExExercise();

            //CheckExam();

            //CheckAnswers();

            //CheckExercise();

            //CheckStudent();

            //CheckSubjects();

            //CheckTeachers();

            //CheckLikes();
            //Students.InsertStudent("Shon12", "1234", "shonshonshom", 2, "Shon", 3, 3);
            //Console.ReadKey();
        }
 
    }
}
