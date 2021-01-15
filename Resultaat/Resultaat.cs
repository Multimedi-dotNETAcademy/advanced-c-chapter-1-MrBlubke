using System;
using System.Collections.Generic;
using System.Text;

namespace Opdracht
{
    class Resultaat
    {
        private double _percentage;

        public void Percentage(double inputPercentage)
        {
            _percentage = Math.Round(inputPercentage, 1);
        }


        public void PrintGraad()
        {

            if (_percentage < 50)
            {
                Console.WriteLine($"De behaalde graad is <Niet geslaagd>.");
            }
            else if (_percentage < 68)
            {
                Console.WriteLine($"De behaalde graad is <Voldoende>.");
            }
            else if (_percentage < 75)
            {
                Console.WriteLine($"De behaalde graad is <Onderscheiding>.");
            }
            else if (_percentage < 85)
            {
                Console.WriteLine($"De behaalde graad is <Grote Onderscheiding>.");
            }
            else
            {
                Console.WriteLine($"De behaalde graad is <Grootste Onderscheiding>. Proficiat!.");
            }
        }

    }
}
