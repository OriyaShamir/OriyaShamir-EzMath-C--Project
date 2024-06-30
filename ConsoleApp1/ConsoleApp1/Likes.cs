using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ConsoleApp1
{
    public class Likes
    {
        ///// <summary>
        ///// Check if the given student already voted. If he did update his vote according to liked parameter. Else:
        ///// If he already clicked Like or Dislike and he clicks again, It will delete their vote (Like or dislike)
        ///// Like or Dislike an exercise, if liked = YES ==> like, if liked = NO ==> dislike.
        ///// </summary>
        ///// <param name="studentid"></param>
        ///// <param name="exid"></param>
        ///// <param name="liked"></param>
        ///// <returns></returns>
        static public int Insertlike(int studentID,int ExamID, bool Liked)
        {
           string sSql = "INSERT INTO likes (StudentID,ExID,Liked) " +
                    "VALUES (" + studentID + "," + ExamID + "," + Liked + ")";
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }
        /// <summary>
        /// Update like (yes or no)
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="ExamID"></param>
        /// <param name="Liked"></param>
        /// <returns></returns>
        static public int UpdateLikes(int studentID,int ExamID, bool Liked)
        {
           string sSql = "UPDATE Likes SET Liked = "+Liked+" WHERE StudentID = " + studentID + " AND ExID = " + ExamID;
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }
        /// <summary>
        /// Return 0 if not voted, 1 if liked and -1 if disliked.
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="exid"></param>
        /// <returns></returns>
        static public int Voted(int studentid, int exid)
        {
            string sSql = "SELECT Liked FROM Likes WHERE StudentID = " + studentid + "  AND ExID = " + exid;
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt == null || dt.Rows.Count == 0)
            {
                return 0;
            }
            else
            {
                bool v = (bool)dt.Rows[0]["Liked"];
                if (v == true)
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
            }
        }
        /// <summary>
        /// Return the amount of likes to the specified exercise.
        /// </summary>
        /// <param name="exid"></param>
        /// <returns></returns>
        static public int GetLikesForEx(int exid)
        {
            string sSql = "SELECT * FROM Likes WHERE ExID = " + exid + " AND Liked = true";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null)
            {
                return dt.Rows.Count;
            }
            return 0;
        }
        /// <summary>
        /// Return the amount of dislikes to the specified exercise.
        /// </summary>
        /// <param name="exid"></param>
        /// <returns></returns>
        static public int GetDisLikesForEx(int exid)
        {
            string sSql = "SELECT * FROM Likes WHERE ExID = " + exid + " AND Liked = false";
            DataTable dt = DBHelper.GetDataTable(sSql);
            if (dt != null)
            {
                return dt.Rows.Count;
            }
            return 0;
        }
        /// <summary>
        /// Remove vote from the table
        /// </summary>
        /// <param name="studentid"></param>
        /// <param name="exid"></param>
        /// <returns></returns>
        static public int DeleteRecord(int studentid, int exid)
        {
            string sSql = "DELETE FROM Likes WHERE StudentID = " + studentid + " AND ExID = " + exid;
            int rowsAffected = DBHelper.ExecuteNonQuery(sSql);
            return rowsAffected;
        }

    }
}
