using System;
using System.Collections.Generic;
using System.IO;

namespace JURNAL2
{
    public class AdministrareUtilizatori
    {
        private List<Utilizator> utilizatori = new List<Utilizator>();
        private const string FisierUtilizatori = "utilizatori.txt";

        public AdministrareUtilizatori()
        {
            if (File.Exists(FisierUtilizatori))
            {
                string[] linii = File.ReadAllLines(FisierUtilizatori);
                foreach (var linie in linii)
                {
                    Utilizator utilizator = Utilizator.FromString(linie);
                    if (utilizator != null)
                    {
                        utilizatori.Add(utilizator);
                    }
                }
            }
        }

       
        public void AdaugaUtilizator(Utilizator utilizator)
        {
            utilizatori.Add(utilizator);
        }

        public Utilizator GasesteUtilizator(string nume)
        {
            return utilizatori.Find(u => u.Nume.Equals(nume, StringComparison.OrdinalIgnoreCase));
        }

       
        public List<Utilizator> GetUtilizatori()
        {
            return utilizatori;
        }

        public void AfiseazaUtilizatori()
        {
            if (utilizatori.Count > 0)
            {
                foreach (var utilizator in utilizatori)
                {
                    Console.WriteLine($"Utilizator: {utilizator.Nume}");
                }
            }
            else
            {
                Console.WriteLine("Nu există utilizatori.");
            }
        }
    }
}
