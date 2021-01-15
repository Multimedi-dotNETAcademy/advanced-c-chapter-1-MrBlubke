using System;
using System.Collections.Generic;
using System.Text;

namespace IntroductieClasses
{
    class Car
    {
        public string color;
        public string brand;
        public string model;
        public int year;

        public void Accelerator()
        {
            Console.WriteLine("Vroooooom");
        }

       public void StartCar()
        {
            Console.WriteLine("Car is running...");
        }
    }
}
