using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// represents an individual student
    /// </summary>
    class Student
    {
        /// <summary>
        /// the student's legal first name 
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// legal last name
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// list of courses student
        /// </summary>
        public List<Course> Schedule { get; set; }

    }
}
