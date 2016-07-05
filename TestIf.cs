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
}
