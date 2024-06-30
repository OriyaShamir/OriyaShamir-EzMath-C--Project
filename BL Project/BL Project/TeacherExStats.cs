            using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL_Project
{
    public class TeacherExStats
    {
        private double generalStats;
        private double teacherStats;
        private double examStats;
        private double examAvg;
        private double classStats;

        public TeacherExStats(double general, double teacher, double exam, double examAvg, double classStats)
        {
            this.examStats = exam;
            this.generalStats = general;
            this.teacherStats = teacher;
            this.examAvg = examAvg;
            this.classStats = classStats;
        }

        /// <summary>
        /// Get general stats of ex
        /// </summary>
        /// <returns></returns>
        public double GetGeneralStats()
        {
            return this.generalStats;
        }
        /// <summary>
        /// get ex stats for teacher
        /// </summary>
        /// <returns></returns>
        public double GetTeacherlStats()
        {
            return this.teacherStats;
        }
        /// <summary>
        /// get the stats of exam
        /// </summary>
        /// <returns></returns>
        public double GetExamStats()
        {
            return this.examStats;
        }
        /// <summary>
        /// get the exam axg
        /// </summary>
        /// <returns></returns>
        public double GetExamAvg()
        {
            return this.examAvg;
        }
        /// <summary>
        /// get the class stats
        /// </summary>
        /// <returns></returns>
        public double GetClassStats()
        {
            return this.classStats;
        }
    }
}
