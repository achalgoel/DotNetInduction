using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleNameSpace;

namespace Assignment_12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vehicle[] vehicles = new Vehicle[3];        //ONLY INITIALIZES THE ARRAY {NOT THE ELEMENTS}
            //for (int i = 0; i < 3;i++ )
            //{
            //    vehicles[i] = new Vehicle();             // FOR INITIALISING THE ELEMENTS OF ARRAY 

            //    Console.WriteLine("Enter details for the vehicles :");

            //    Console.WriteLine("Model :");
            //    vehicles[i].Model = Console.ReadLine();

            //    Console.WriteLine("Year of manufacture :");
            //    vehicles[i].YearOfManufacture = Int32.Parse(Console.ReadLine());

            //    Console.WriteLine("Make :");
            //    vehicles[i].Make = Console.ReadLine();

            //    Console.WriteLine("Speed :");
            //    vehicles[i].Speed = Int32.Parse(Console.ReadLine());

            //    Console.WriteLine();
            //}
            //Console.WriteLine("Order before Sorting:");

            //for (int i = 0; i < 3; i++)
            //{
            //    vehicles[i].DisplayDetails();
            //    Console.WriteLine("Status : " + vehicles[i].IsMoving());
            //}

            //Array.Sort(vehicles);

            //Console.WriteLine();
            //Console.WriteLine("Order after Sorting:");

            //for (int i = 0; i < 3; i++)
            //{
            //    vehicles[i].DisplayDetails();
            //    Console.WriteLine("Status : " + vehicles[i].IsMoving());
            //}

            //Console.ReadKey();

            Vehicle v1 = new Vehicle()
            {
                Make = "Mercedes",
                Model = "GT599",
                YearOfManufacture = 2014,
                Speed = 400
            };

            Vehicle v2 = new Vehicle()
            {
                Make = "Mercedes",
                Model = "GT599",
                YearOfManufacture = 2014,
                Speed = 400
            };

            Console.WriteLine(v2.Equals(v1));
            Console.ReadKey();
            
        }
    }
}
