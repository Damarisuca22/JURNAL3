using System;

namespace JURNAL2
{
    public class Utilizator
    {
        public string Nume { get; set; }

        public Utilizator(string nume)
        {
            Nume = nume;
        }

        public string Info()
        {
            return $"{Nume}";
        }

        public static Utilizator FromString(string linie)
        {
            return new Utilizator(linie);  
        }
    }
}
