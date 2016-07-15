using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleNameSpace;

namespace CarNameSpace
{
   public class Car : Vehicle
    {

        private string _type;
        private int _seating_capacity;


        public Car(string Type, int SeatingCapacity, string make, int yearOfManufacture, string model, float speed)
            : base(make, yearOfManufacture, model, speed)
        {

            this._type = Type;
            this._seating_capacity = SeatingCapacity;

        }

       

        public void DisplayDetails()
        {
            Console.WriteLine("----------------CAR DETAILS---------------");
            base.DisplayDetails();
            Console.WriteLine("Types : " + this._type);
            Console.WriteLine("Seating capacity : " + this._seating_capacity);
        }

    }
}
