using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Course
    {
        /// <summary>
        /// title of the course
        /// Ex: CPW 212 Advanced .NET programming
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// official description of the course
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// number of college credits awarded for passing the course
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// the instructor for the course
        /// </summary>
        public Instructor Instructor { get; set; }

        /// <summary>
        /// list of students enrolled in the course
        /// </summary>
        public List<Student> ClassRoster { get; set; }
    }
}
