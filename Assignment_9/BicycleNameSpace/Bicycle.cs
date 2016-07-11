using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleNameSpace;

namespace BicycleNamespace
{
   public class Bicycle : Vehicle
    {
        private string _cycle_frame;
        private int _gears;



        public Bicycle(string CycleFrame, int Gears, string make, int yearOfManufacture, string model, float speed)
            : base(make, yearOfManufacture, model, speed)
        {

            this._cycle_frame = CycleFrame;
            this._gears = Gears;

        }

        public void DisplayDetails()
        {
            Console.WriteLine("----------------BICYCLE DETAILS---------------");
            base.DisplayDetails();
            Console.WriteLine("Cycle frame : " + this._cycle_frame);
            Console.WriteLine("Gears : " + this._gears);
        }
    }
}
