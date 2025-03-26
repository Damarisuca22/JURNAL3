using System;
using System.Collections.Generic;

namespace JURNAL2
{
    class AdministrareCheltuieli
    {
        private List<Cheltuiala> cheltuieli = new List<Cheltuiala>();

       
        public void AddCheltuiala(Cheltuiala cheltuiala)
        {
            cheltuieli.Add(cheltuiala);
        }

      
        public List<Cheltuiala> GetCheltuieli()
        {
            return cheltuieli;
        }
    }
}
