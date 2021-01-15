using System;

namespace oefeningStudentklasse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Studenten Rapport\n-----------------\n");

            Student[] studenten = new Student[3];

            studenten[0] = new Student("Ward", 46, Klas.EA2, 15, 16, 18);

            studenten[1] = new Student("Frank", 34, Klas.EA1, 13, 15, 12);

            studenten[2] = new Student("Tom", 24, Klas.EA4, 17, 15, 12);

            foreach (Student student in studenten)
            {
                student.GeefOverzicht();
                Console.WriteLine("--------------\n\n");
            }
        }
    }
}
