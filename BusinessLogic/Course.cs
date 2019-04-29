using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic
{
    public class Course
    {
        private string _instructorName;
        private string _courseName;
        private byte _numberOfCredits;

        public Course(string courseName)
        {
            CourseName = courseName;
            InstructorName = "STAFF";
        }

        /// <summary>
        /// The instructor teaching the course
        /// </summary>
        public string InstructorName {
            get {
                return _instructorName;
            }
            set {
                _instructorName = value;
            }
        }

        /// <summary>
        /// The name of the course
        /// </summary>
        public string CourseName {
            get {
                return _courseName;
            }
            set {
                if (value != null)
                {
                    _courseName = value;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
        }

        /// <summary>
        /// Number of credits for the course
        /// </summary>
        public byte NumberOfCredits {
            get {
                return _numberOfCredits;
            }
            set {
                if (value < 30 && value > 0)
                {
                    _numberOfCredits = value;
                }
                else
                {
                    throw new ArgumentException();
                }
            }
        }
    }
}
