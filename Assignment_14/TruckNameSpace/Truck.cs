using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleNameSpace;

namespace TruckNameSpace
{
   public class Truck : Vehicle
    {

        private int _weight_capacity;
        private int _no_of_tyres;


        public Truck(int WeightCapacity, int NoOfTyres, string make, int yearOfManufacture, string model, float speed)
            : base(make, yearOfManufacture, model, speed)
        {

            this._no_of_tyres = NoOfTyres;
            this._weight_capacity = WeightCapacity;

        }

        public void DisplayDetails()
        {
            Console.WriteLine("---------------TRUCK DETAILS---------------");
            base.DisplayDetails();
            Console.WriteLine("No of tyres : " + this._no_of_tyres);
            Console.WriteLine("Weight capacity (in tonnes) : " + this._weight_capacity);
            
        }

    }
}
