﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    class Student
    {
        private int _EnrollmentNo;
        private string _FirstName;
        private string _LastName;
        private int _Age;
        private float _Percentage;
        private float _Attendance;

     


        public int EnrollmentNo
        {   
            
            set
            {
                if (this._EnrollmentNo == 0)
                {
                    Random rd = new Random();
                    this._EnrollmentNo = rd.Next(1111, 9999);
                    Console.WriteLine("Auto Generating Enrollment Number");
                }
                else
                    Console.WriteLine("Enrollment Number already generated");
            }

            get
            {
                return this._EnrollmentNo;
            }
        }

        public string FirstName
        {
            set
            {
                if (value != null)
                    this._FirstName = value;
                else
                    throw new Exception("FirstName cannot be null !");
            }
            get
            {
                return this._FirstName;
            }
        }

        public string LastName
        {
            set
            {
                if (value != null)
                    this._LastName = value;
                else
                    throw new Exception("LastName cannot be null !");
            }
            get
            {
                return this._LastName;
            }
        }

        public int Age
        {
            set
            {
                if (value > 3 && value < 30)
                    this._Age = value;
                else
                    throw new Exception("Age should be between 3 & 30");
            }

            get
            {
                return this._Age;
            }
        }

        public float Percentage
        {
            set
            {
                if (value >= 0 && value <= 100)
                    this._Percentage = value;
                else
                    throw new Exception("Percentage should be between 0 & 100");
            }

            get
            {
                return this._Percentage;
            }
        }

        public float Attendance
        {
            set
            {
                if (value >= 0 && value <= 100)
                    this._Attendance = value;
                else
                    throw new Exception("Attendance should be between 0 & 100");
            }

            get
            {
                return this._Attendance;
            }
        }

        public Student()
        {}

        public Student(int a, string b, string c, int d, float e, float f)
        {
            _EnrollmentNo = a;
            _FirstName = b;
            _LastName = c;
            _Age = d;
            _Percentage = e;
            _Attendance = f;
        }

        public void ShowDetails()
        {
            Console.WriteLine("Welcome to student Portal");
            Console.WriteLine("Here are the details of the student you requested !");
            Console.WriteLine("Enrollment Number :{0}", this._EnrollmentNo);
            Console.WriteLine("First Name :{0}", this._FirstName);
            Console.WriteLine("Last Name :{0}", this._LastName);
            Console.WriteLine("Age of student :{0}", this._Age);
            Console.WriteLine("Aggregate Percentage :{0}", this._Percentage);
            Console.WriteLine("Attendance(%) ;{0}", this._Attendance);
        }

        private enum StudentAttribute {_EnrollmentNo,_FirstName,_LastName,_Age,_Percentage,_Attendance};

        public void ShowDetails(int choice)                 //Overloaded Showdetails
        {
            Console.WriteLine("Welcome to student Portal");
            Console.WriteLine("Here are the details of the student you requested !");
            StudentAttribute sa = (StudentAttribute)(choice-1);
            switch (sa)
            {
                case StudentAttribute._EnrollmentNo:
                    Console.WriteLine("Enrollment Number :{0}", this._EnrollmentNo);
                    break;

                case StudentAttribute._FirstName:
                    Console.WriteLine("First Name :{0}", this._FirstName);
                    break;
                case StudentAttribute._LastName:
                    Console.WriteLine("Last Name :{0}", this._LastName);
                    break;
                case StudentAttribute._Age:
                    Console.WriteLine("Age of student :{0}", this._Age);
                    break;
                case StudentAttribute._Percentage:
                    Console.WriteLine("Aggregate Percentage :{0}", this._Percentage);
                    break;
                case StudentAttribute._Attendance:
                    Console.WriteLine("Attendance(%) ;{0}", this._Attendance);
                    break;
            }

           
        }
    }




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
        }
    }
}
