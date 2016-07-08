using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentNameSpace;
namespace CollegeStudent
{
    public class CollegeStudent : Student
    {
        private int _semester;
        private string _branch;

        public CollegeStudent
            (
            int Semester,
            string Branch,
            int EnrollmentNo,
            string FirstName,
            string LastName,
            int Age,
            float Percentage,
            float Attendance
            )
            : base
            (
             EnrollmentNo,
             FirstName,
             LastName,
             Age,
             Percentage,
             Attendance
            )
        {
            this._semester = Semester;
            this._branch = Branch;
        }

        public void Display()
        {
            base.ShowDetails();
            Console.WriteLine("Standard : " + this._semester);
            Console.WriteLine("Section : " + this._branch);
        }
    }
}
