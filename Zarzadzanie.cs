using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class Zarzadzanie
    {
        private List<Samochod> samochody = new List<Samochod>();
        private List<Klient> klienci = new List<Klient>();

        public void DodajSamochod(string marka, string model, int rocznik, int przebieg, decimal cena, bool czySprzedany)
        {
            samochody.Add(new Samochod(marka, model, rocznik, przebieg, cena, czySprzedany));
        }

        public void DodajKlienta(string imie, string nazwisko, string adres, string telefon)
        {
            klienci.Add(new Klient(imie, nazwisko, adres, telefon));
        }

        public List<Samochod> PobierzSamochody()
        {
            return samochody;
        }

        public List<Klient> PobierzKlientow()
        {
            return klienci;
        }
    }
}
