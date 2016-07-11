using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleNameSpace;
using BicycleNamespace;
using CarNameSpace;
using BikeNamespace;
using TruckNameSpace;

namespace Assignment_9
{
  
    class Program
    {
        static void Main(string[] args)
        {
            Bicycle v1 = new Bicycle("Carbon Fibre", 20, "Hero", 2010, "BMZX", 60);
            v1.DisplayDetails();
            Console.WriteLine();
            v1.Accelerate(6, 5);
            Console.WriteLine();
            v1.DisplayDetails();
            Console.WriteLine();
            v1.Deaccelerate(2, 4);
            Console.WriteLine();
            v1.DisplayDetails();
            Console.WriteLine();
            Console.WriteLine("Vehicle status : Moving = "+ v1.IsMoving());
            v1.Stop();
            Console.WriteLine();
            Console.WriteLine("Vehicle status : Moving = " + v1.IsMoving());
            Console.WriteLine();

            Console.WriteLine();


            Car v11 = new Car("Convertible", 4, "Mercedes", 2015, "S GT250", 160);
            v11.DisplayDetails();
            Console.WriteLine();
            v11.Accelerate(6, 5);
            Console.WriteLine();
            v11.DisplayDetails();
            Console.WriteLine();
            v11.Deaccelerate(2, 4);
            Console.WriteLine();
            v11.DisplayDetails();
            Console.WriteLine();
            Console.WriteLine("Vehicle status : Moving = " + v11.IsMoving());
            v11.Stop();
            Console.WriteLine();
            Console.WriteLine("Vehicle status : Moving = " + v11.IsMoving());
        }
    }
}
