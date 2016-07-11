using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleNameSpace;

namespace BikeNamespace
{
     public class Bike : Vehicle
    {
        private string _brakes;
        private int _mileage;



        public Bike(string Brakes, int Mileage, string make, int yearOfManufacture, string model, float speed)
            : base(make, yearOfManufacture, model, speed)
        {

            this._brakes = Brakes;
            this._mileage = Mileage;

        }

        public void DisplayDetails()
        {
            Console.WriteLine("----------------BIKE DETAILS---------------");
            base.DisplayDetails();
            Console.WriteLine("Brakes : " + this._brakes);
            Console.WriteLine("Mileage : " + this._mileage);
        }

    }
}
