using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleNameSpace;
using VehicleCollection;

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
                Make = "Lambourghini",
                Model = "GT599",
                YearOfManufacture = 2004,
                Speed = 450
            };

            Vehicle v3 = new Vehicle()
            {
                Make = "Ferrari",
                Model = "Brrrrrrr",
                YearOfManufacture = 1999,
                Speed = 300
            };

            Vehicle v4 = new Vehicle()
            {
                Make = "Mercedes",
                Model = "FS250",
                YearOfManufacture = 2015,
                Speed = 40
            };

            Vehicle v5 = new Vehicle()
            {
                Make = "Ford",
                Model = "Mustang",
                YearOfManufacture = 1970,
                Speed = 200
            };


            Console.WriteLine(v2.Equals(v1));                      
            Console.ReadKey();


            //VehicleCollection.VehicleCollection list = new VehicleCollection.VehicleCollection();

            //list.Add(v1);
            //list.Add(v2);
            //list.Add(v3);
            //list.Add(v4);
            //list.Add(v5);

            //foreach (Vehicle item in list)
            //{
            //    item.DisplayDetails();
            //}
        }
    }
}
