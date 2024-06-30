using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Project
{
    public class StudentGrade
    {
        private string path;
        private int id;
        private double grade;

        public StudentGrade(string path, int id, double grade)
        {
            this.path = path;
            this.id = id;
            this.grade = grade;
        }

        /// <summary>
        /// Get's the current path 
        /// </summary>
        /// <returns></returns>
        public string getPath()
        {
            return this.path;
        }

        /// <summary>
        /// Get's current id 
        /// </summary>
        /// <returns></returns>
        public int getID()
        {
            return this.id;
        }
        /// <summary>
        /// Get's current grade 
        /// </summary>
        /// <returns></returns>
        public double getGrade()
        {
            return this.grade;
        }
    }
}
