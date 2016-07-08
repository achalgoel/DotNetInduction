using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentNameSpace;
using CollegeStudent;

namespace Assignment8
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(22222, "Achal", "Goel", 21, 96, 95);
            s1.ShowDetails();

            Console.WriteLine("--------------------------------------------------------------------");
            s1.ShowDetails(2);

            Console.WriteLine("--------------------------------------------------------------------");
            Student s2 = new Student();
            s2.FirstName = "Ayush";
            s2.EnrollmentNo = 23;
            Console.WriteLine(s2.EnrollmentNo);
            Console.WriteLine("--------------------------------------------------------------------");
            s2.EnrollmentNo = 23;
            Console.WriteLine(s2.EnrollmentNo);
            Console.WriteLine("--------------------------------------------------------------------");
            s2= new Student(5624,"Ron","Roy",12,85,65);
            s2.ShowDetails();

            CollegeStudent.CollegeStudent s3 = new CollegeStudent.CollegeStudent(6,"Information Technology",25634,"Gopal","Krishan",21,99,85);
            s3.ShowDetails();
        }
    }
}
