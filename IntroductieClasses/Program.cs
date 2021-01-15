using System;

namespace IntroductieClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Car wagen = new Car();
            wagen.brand = "Volvo";
            wagen.color = "Magic Blue";
            wagen.model = "XC70";
            wagen.year = 2016;

            string result =
                $"You have a {wagen.color} {wagen.brand} {wagen.model} which " +
                $"was constructed in {wagen.year} ";

            Console.WriteLine(result);
            wagen.StartCar();
            wagen.Accelerator();

         }
    }
}
