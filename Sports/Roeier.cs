using System;
using System.Collections.Generic;
using System.Text;

namespace Sports
{

    class Roeier
    {
        
        private string naam;

        public string Naam
        {
            get { return naam; }
            set { naam = value; }
        }

        private int locatie;

        public int Locatie
        {
            get { return locatie; }
            set { locatie = value; }
        }

        private bool isStuurman;
        private int aantalRoeiersInBoot;
        private TypeBoot typeBoot;

        public void HardSlagen(int aantalHardeSlagen)
        {
            Console.WriteLine($"\nEn Nu {naam} {aantalHardeSlagen} harde slagen!");
        }
        public void Roeien()
        {
            Console.WriteLine($"{naam}, begin (terug) met gewoon roeien.");
        }
        public bool StelIn(string Naam,int locatie,bool isStuurman, TypeBoot typeBoot)
        {
            return true;
        }
    }


}
