using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;


namespace VehicleNameSpace
{
    public class Vehicle : System.Object, IComparable<Vehicle>,IEquatable<Vehicle>,IComparer<Vehicle>
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

        public Vehicle() { }

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
            Console.WriteLine();
            Console.WriteLine("Make : " + this._make);
            Console.WriteLine("Year of manufacture ; " + this._year_of_manufacture);
            Console.WriteLine("Model no. : " + this._model);
            Console.WriteLine("Speed : " + this._speed);
        }

        public int CompareTo(Vehicle other)                   //Implementing IComparable
        {
            if (
                this._year_of_manufacture > other._year_of_manufacture 
                //|| this.Make != other.Make 
                //|| this.Model != other.Model
                )
                return 1;
            else if (
                this._year_of_manufacture < other._year_of_manufacture 
                //|| this.Make != other.Make 
                //|| this.Model != other.Model
                )
                return -1;
            else
                return 0;
        }

        public override bool Equals(System.Object vehicle)          //Override Equals (method in object class)
        {
            Vehicle obj = (Vehicle)vehicle;

            if (obj == null)
                return false;
            else if (!(obj is Vehicle))
                return false;
            else
                return
                    (
                    obj.Make == this.Make &&
                    obj.Model == this.Model &&
                    obj.Speed == this.Speed &&
                    obj.YearOfManufacture == this.YearOfManufacture
                    );
        }



        public bool Equals(Vehicle vehicle)            // Implementation of IEquitable
        {
            Vehicle obj = (Vehicle)vehicle;

            if (obj == null)
                return false;
            else if (!(obj is Vehicle))
                return false;
            else
                return
                    (
                    obj.Make == this.Make &&
                    obj.Model == this.Model &&
                    obj.Speed == this.Speed &&
                    obj.YearOfManufacture == this.YearOfManufacture
                    );
        }
    
        public int Compare(Vehicle x, Vehicle y)
        {

            return x.CompareTo(y);
        }
}
 }
