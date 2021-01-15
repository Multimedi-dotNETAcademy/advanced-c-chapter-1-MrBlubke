using System;

namespace Opdracht
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("OEFENING RAPPORTMODULE");
            Console.WriteLine();

            Resultaat resultaat = new Resultaat();

            Console.WriteLine("Geef het behaalde percentage in.");
            double percentage = Convert.ToDouble(Console.ReadLine());


            resultaat.Percentage(percentage);

            resultaat.PrintGraad();
        }
    }
}
