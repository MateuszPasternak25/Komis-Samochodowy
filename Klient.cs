using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Klient
    {
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }

        public Klient(string imie, string nazwisko, string adres, string telefon)
        {
            Imie = imie;
            Nazwisko = nazwisko;
            Adres = adres;
            Telefon = telefon;
        }
    }
}
