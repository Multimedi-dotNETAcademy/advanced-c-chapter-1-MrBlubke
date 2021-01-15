using System;
using System.Collections.Generic;
using System.Text;

namespace oefeningStudentklasse
{
    public enum Klas { EA1, EA2, EA3, EA4 }

    class Student
    {

        public string Naam;
        public int Leeftijd;
        public Klas Klas;
        public int PuntenCommunicatie;
        public int PuntenProgrammingPrinciples;
        public int PuntenWebTech;

        public Student(string naam, int leeftijd, Klas klas, int puntenCommunicatie, int puntenProgrammingPrinciples, int puntenWebTech)
        {
            Naam = naam;
            Leeftijd = leeftijd;
            Klas = klas;
            PuntenCommunicatie = puntenCommunicatie;
            PuntenProgrammingPrinciples = puntenProgrammingPrinciples;
            PuntenWebTech = puntenWebTech;
        }

        public double BerekenTotaalCijfer()
        {
            //double PuntC = Convert.ToDouble(PuntenCommunicatie);
            //double PuntP = Convert.ToDouble(PuntenProgrammingPrinciples);
            //double PuntW = Convert.ToDouble(PuntenWebTech);
            //double gemidd = (PuntC + PuntP + PuntW) / 3;
            //return gemidd;

            return Math.Round(((Convert.ToDouble(PuntenCommunicatie) + Convert.ToDouble(PuntenProgrammingPrinciples) + Convert.ToDouble(PuntenWebTech)) / 3), 1);

        }

        public void GeefOverzicht()
        {
            Console.WriteLine($"{Naam}, {Leeftijd} jaar " +
                $"\nKlas: {Klas} " +
                $"\n" +
                $"\nCijferrapport:" +
                $"\n***********" +
                $"\nCommunicatie:               {PuntenCommunicatie}" +
                $"\nProgramming Principles:     {PuntenProgrammingPrinciples}" +
                $"\nWeb Technology:             {PuntenWebTech}" +
                $"\nGemiddelde:                 {BerekenTotaalCijfer()}");
        }

    }
}