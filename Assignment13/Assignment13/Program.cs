using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleNameSpace;
using VehicleArrayNameSpace;

namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {

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
            VehicleArray va1 = new VehicleArray();
            va1.Add(v1);
            va1.Add(v2);
            va1.Add(v3);
            va1.Add(v4);
            va1.Add(v5);

            foreach (Vehicle v in va1)
            {
               Console.WriteLine( v.Make.ToString());
            }
        }
    }
}
