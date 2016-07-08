using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentNameSpace;

namespace SchoolStudent
{
    public class SchoolStudent : Student
    {
        private int _standard;
        private string _section;

        public SchoolStudent
            (
            int Standard, 
            string Section, 
            int EnrollmentNo,
            string FirstName,
            string LastName,
            int Age,
            float Percentage, 
            float Attendance
            )
                :base
                (
                 EnrollmentNo,
                 FirstName,
                 LastName,
                 Age,
                 Percentage,
                 Attendance
                )
        {
            this._standard = Standard;
            this._section = Section;
        }

        public void Display()
        {
            base.ShowDetails();
            Console.WriteLine("Standard : "+this._standard);
            Console.WriteLine("Section : "+this._section);
        }
    }
}
