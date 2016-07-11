using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleNameSpace
{
    public class Vehicle
    {
        private string _make;
        private int _year_of_manufacture;
        private string _model;
        private float _speed;

        public Vehicle(string make, int yearOfManufacture, string model, float speed)
        {
            this._make = make;
            this._year_of_manufacture = yearOfManufacture;
            this._model = model;
            this._speed = speed;
        }

        public Vehicle()
        {

        }

        public void Accelerate(int acceleration, int time)
        {
            Console.WriteLine("Accelerating Speed .............");
            this._speed = this._speed + (acceleration * time);
        }

        public void Deaccelerate(int deacceleration, int time)
        {
            Console.WriteLine("Deaccelerating Speed .............");
            this._speed = this._speed - (deacceleration * time);
        }

        public void Stop()
        {
            Console.WriteLine("Stopping the Vehicle .............");
            this._speed = 0;
        }

        public bool IsMoving()
        {
            if (this._speed == 0)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public string Make
        {
            set
            {
                _make = value;
            }
            get
            {
                return _make;
            }
        }

        public int YearOfManufacture
        {
            set
            {
                if (value >= 1950 && value <= 2016)
                {
                    _year_of_manufacture = value;
                }
                else
                    throw new Exception("Year of manufacture should be between 1950 & 2016");
            }
            get
            {
                return _year_of_manufacture;
            }
        }

        public string Model
        {
            set
            {
                _model = value;
            }
            get
            {
                return _model;
            }
        }

        public float Speed
        {
            set
            {
                if (value >= 0 && value <= 500)
                    _speed = value;
                else
                    throw new Exception("Speed should be between 0 and 500");
            }
            get
            {
                return _speed;
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Make : " + this._make);
            Console.WriteLine("Year of manufacture ; " + this._year_of_manufacture);
            Console.WriteLine("Model no. : " + this._model);
            Console.WriteLine("Speed : " + this._speed);
        }

    }
}
