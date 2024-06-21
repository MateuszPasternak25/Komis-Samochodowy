using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Samochod
    {
        public string Marka { get; set; }
        public string Model { get; set; }
        public int Rocznik { get; set; }
        public int Przebieg { get; set; }
        public decimal Cena { get; set; }
        public bool CzySprzedany { get; set; }

        public Samochod(string marka, string model, int rocznik, int przebieg, decimal cena, bool czySprzedany)
        {
            Marka = marka;
            Model = model;
            Rocznik = rocznik;
            Przebieg = przebieg;
            Cena = cena;
            CzySprzedany = czySprzedany;
        }
    }
}
