using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OBJ_SHAREFILE
{
    class Car
    {
       //MANUAL ENCAPSULATION
       //int yearMake { get; set; }
       private int _yearMake;
       public int yearMake
       {
            get { return _yearMake; } //READ
            set { _yearMake = value; } //WRITE
       }

       //AUTO PROPERTIES -> Saves time/Same as above but easy
       string carModel { get; set; } //_carModel
       int maxSpeed { get; set; } //_maxSpeed

        //CONSTRUCTOR
        public Car(int year, string model, int speed)
        {
            yearMake = year;
            carModel = model;
            maxSpeed = speed;
        }

        //METHOD BEHAVE
        public void CarSound()
        {
            Console.WriteLine("The car goes vroom");
        }

        //Get Values SAFE (Private vs Public Access)
        public string ExpoCarModel()
        {
            return carModel;
        }
        public int ExpoMaxSpeed()
        {
            return maxSpeed;
        }

        //CHANGE THE CAR YEAR MAKE
        public int ChangeCarMake(int year)
        {
            yearMake = (int)year;
            return yearMake;
        }

        public int ExpoCarMake()
        {
            return yearMake;
        }
    }
}
