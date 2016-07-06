using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your CHOICE :");
            Console.WriteLine("1. If Else");
            Console.WriteLine("2. Switch Case :");
            Console.WriteLine("3. Enums");
            Console.WriteLine("4. String Operations");
            Console.WriteLine("5. String Arrays");
            Console.WriteLine("6. Encapsulation");
            Console.WriteLine();
            Console.Write("Enter YOUR CHOICE here :");
            int choice;
            choice = int.Parse(Console.ReadLine());
        
            switch (choice)
            {
                case 1:
                    Console.WriteLine("If else");
                    IfElse obj1 = new IfElse();
                    obj1.ifelse();
                    break;
                case 2:

                    Console.WriteLine("Switch case");
                    SwitchCase obj2 = new SwitchCase();
                    obj2.switchcase();
                    break;
                case 3:

                    Console.WriteLine("Enums");
                    EnumProgram obj3 = new EnumProgram();
                    obj3.Enums();
                    break;

                case 4:

                    Console.WriteLine("String Operations");
                   TestStrings obj4 = new TestStrings();
                    obj4.stringcompare ();
                    break;

                case 5:
                    Console.WriteLine("Array of string");
                    Console.WriteLine("Enter number for day of a week :");
                    int ch = Int32.Parse(Console.ReadLine());
                    Console.WriteLine(GetStringArray(ch));
                    Console.ReadKey();
                    break;
            }
        }

      public static  string GetStringArray(int choice)
        {
            
            string[] str= new string[7];
            for (int i = 0; i < 7; i++)
            { 
                DayOfWeek d=(DayOfWeek)i;
                str[i]=d.ToString();
            }
                return str[choice];
            
        }
    }


   

    class IfElse
    { 
        public void ifelse()
        {
            Console.WriteLine("Enter Your CHOICE of language :");
            Console.WriteLine("1. VB.Net");
            Console.WriteLine("2. C# :");
            Console.WriteLine("3. Any other");
            Console.Write("Enter here :");
            int choice;
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine(" VB .NET: OOP, multithreading and more!");
            }
            else if (choice == 2)
            {
                Console.WriteLine("C# is a great language");
            }
            else 
            {
                Console.WriteLine("Good Luck with hat !");
            }
        }
    }

    class SwitchCase
    {
        public void switchcase()
        {
            Console.WriteLine("Enter Your CHOICE :");
            Console.WriteLine("1. VB.Net");
            Console.WriteLine("2. C# :");
            Console.WriteLine("3. Any other");
            Console.Write("Enter here :");
            int choice;
            choice = int.Parse(Console.ReadLine());
            var a = Convert.ToInt32("32");
            var b = Convert.ToInt32("xyz");
            switch (choice)
            {
                case 1:

                    Console.WriteLine(" VB .NET: OOP, multithreading and more!");

                    break;
                case 2:

                    Console.WriteLine("C# is a great language");
                    break;
                case 3:

                    Console.WriteLine("Good Luck with hat !");
                    break;
            }
        }
    }

    class EnumProgram
    {
       public enum Days { Sun, Mon, tue, Wed, thu, Fri, Sat };

        public void Enums()
        {
            int WeekdayStart = (int)Days.Mon;
            int WeekdayEnd = (int)Days.Fri;
            Console.WriteLine("Monday: {0}", WeekdayStart);
            Console.WriteLine("Friday: {0}", WeekdayEnd);
            Console.ReadKey();

               int a = (int)5;
        Days d = (Days)a;
        Console.WriteLine(d);
        }
     
    }

    class TestStrings
    {
        public void stringcompare()
        {
            Console.WriteLine(); 

            string str1 = "This is a test STRING for String Operations";
            string str2 = "This is also a test STRING ";
            Console.WriteLine("Given :");
            Console.WriteLine("String 1 : "+str1);
            Console.WriteLine("String 2 : " + str2);

            Console.WriteLine();                       

            int var1 =string.Compare( str1, str2);                      //String compare
            Console.WriteLine("String Compare Result :{0}",var1 );

            Console.WriteLine(); 

            String str3 = string.Concat(str1, str2);                   //String concat
            Console.WriteLine("Concatenated String : "+str3);

            Console.WriteLine();

            str3 = string.Copy(str1);                                  //String copy
            Console.WriteLine("String 1 copied : "+str3);

            Console.WriteLine(); 

            bool var2=str1.Equals("Hi");                              //String equals
            Console.WriteLine("String equals result: {0}", var2);

            str3 = string.Join(" ", str1, str2);                        //String Join
            Console.WriteLine("Joining Strings : " + str3);
        }


    }


    
}

