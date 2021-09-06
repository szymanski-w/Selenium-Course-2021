using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritingAClass
{
    class Car
    {
     //private variables that help us define properties of a car (or a class)
        string color;
        int numberOfDoors;
        bool isConvertable;

     //constructor - factory for creating objects of the class
        public Car(string carColor, int doors, bool convertable) //like a method but without return type. You need to tie these to get;set; accessors
        {
            Color = carColor;
            NumberOfDoors = doors;
            IsConvertable = convertable;
            //if you assign these values directly to variables, you will completely bypass any validation or error checking from get/set accessors
        }
            //you can create a class without any constructor - compilor will do it for you with default settings. 
            //public Car(){} - like this. Makes sense if you for example don't want any incoming values

            //also, you can have as many constructors as you want


     //Properties - Get and set accessors - define noun-like attributes of the class
        public string Color
        {
            get
            {
                //you can add smoething here
                return color;
            }
            set
            {
                color = value;
            }
        }

        public bool IsConvertable { get; set; } //if you don't want to add anything, this will do

        public int NumberOfDoors
        {
            get
            { return numberOfDoors; }
            set
            {
                if (value <= 4)
                {
                    numberOfDoors = value;
                }
                else
                {
                    //give the user some kind of appropriate error
                }

            }
        }


     //Methods - verb attributes that tell what a class can do
        public void Accelerate()
        {
            Console.WriteLine("BRRRRRRRRAPAPAPAPAPAPA");
        }

        public bool FamilyCar()
        {
            if (NumberOfDoors >= 4) //always access through the accessors
                return true;
            else
                return false;
        }
    }
}
