using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleNameSpace;
using TruckNameSpace;
using CarNameSpace;

namespace Assignment_14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehiclelist = new List<Vehicle>(3);

            Vehicle v1 = new Vehicle { Make = "mercedes", Model = "GT", YearOfManufacture = 2000, Speed = 90 };
            Vehicle v2 = new Vehicle { Make = "ferrari", Model = "QGT", YearOfManufacture = 2001, Speed = 90 };
            Vehicle v3 = new Vehicle { Make = "ducati", Model = "BT", YearOfManufacture = 1999, Speed = 80 };
            Vehicle v4 = new Vehicle { Make = "Hero", Model = "FZ", YearOfManufacture = 2000, Speed = 50 };

            Car c1 = new Car("sedan", 5, "Ara", 1995, "hh", 150);
            Car c2 = new Car("HatchBack", 5, "Cruze", 2005, "tth", 50);

            Truck t1 = new Truck(20, 20, "Tata", 2015, "407", 200);
            Truck t2 = new Truck(20, 20, "Tata", 2015, "407", 20);

            vehiclelist.Add(v1);
            vehiclelist.Add(v2);
            vehiclelist.Add(v3);
            vehiclelist.Add(v4);

            vehiclelist.Add(c1);
            vehiclelist.Add(c2);

            vehiclelist.Add(t1);
            vehiclelist.Add(t2);
            
            
            foreach (Vehicle item in vehiclelist)
            {
                item.DisplayDetails();
            }

            Console.WriteLine("Comparing t1 & t2 :" );
            if (vehiclelist[6].CompareTo(vehiclelist[7]) == 0)
                Console.WriteLine("TRUE");
            else
                Console.WriteLine("FALSE");

            Console.WriteLine("Comparing v3 & t2 :" );
            if (vehiclelist[3].CompareTo(vehiclelist[7]) == 0)
                Console.WriteLine("TRUE");
            else
                Console.WriteLine("FALSE");
            

            Console.WriteLine("List before sorting : ");

            foreach (Vehicle item in vehiclelist)
            {
                Console.WriteLine("");
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
            }

            vehiclelist.Sort();

            Console.WriteLine("List After sorting : ");

            foreach (Vehicle item in vehiclelist)
            {
                Console.WriteLine("");
                Console.WriteLine(item.Make);
                Console.WriteLine(item.Model);
            }
            Console.ReadKey();
        }


    }
}
