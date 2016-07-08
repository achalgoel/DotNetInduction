using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_9
{
    class Vehicle
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
                if(value>=0 && value<=500)
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
            Console.WriteLine("Make : "+this._make);
            Console.WriteLine("Year of manufacture ; "+this._year_of_manufacture);
            Console.WriteLine("Model no. : "+this._model);
            Console.WriteLine("Speed : "+this._speed);        
        }

    }


    class Bicycle : Vehicle
    {
        private string _cycle_frame;
        private int _gears;



        public Bicycle(string CycleFrame, int Gears,string make, int yearOfManufacture, string model, float speed) 
            : base(make,yearOfManufacture,model,speed)
        {
          
            this._cycle_frame = CycleFrame;
            this._gears = Gears;
          
        }

        public void DisplayDetails()
        {
            Console.WriteLine("----------------BICYCLE DETAILS---------------");
            base.DisplayDetails();
            Console.WriteLine("Cycle frame : "+this._cycle_frame);
            Console.WriteLine("Gears : "+this._gears);
        }
    }

    class Bike : Vehicle
    {
        private string _brakes;
        private int _mileage;



        public Bike(string Brakes, int Mileage, string make, int yearOfManufacture, string model, float speed) : base(make, yearOfManufacture, model, speed)
        {

            this._brakes = Brakes;
            this._mileage = Mileage;

        }

        public void DisplayDetails()
        {
            Console.WriteLine("----------------BIKE DETAILS---------------");
            base.DisplayDetails();
            Console.WriteLine("Brakes : "+this._brakes);
            Console.WriteLine("Mileage : "+this._mileage);
        }

    }

    class Car : Vehicle
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

    class Truck : Vehicle
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
