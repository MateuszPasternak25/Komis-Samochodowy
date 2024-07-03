using System.Windows.Forms;
using System.Linq;
using System.Collections.Generic;

public class Zarzadzanie
{
    List<Klient> klienci;
    List<Samochod> samochody;
    int przypiszId, przypiszIdKlienta;

    public Zarzadzanie()
    {
        klienci = new List<Klient>();
        samochody = new List<Samochod>();
        przypiszId = 1;
        przypiszIdKlienta = 1;
    }

    public void DodajKlienta(string imie, string nazwisko, string adres, string numerTelefonu)
    {
        var klient = new Klient(przypiszIdKlienta++, imie, nazwisko, adres, numerTelefonu);
        klienci.Add(klient);
    }

    public void UsunKlienta(int id)
    {
        var klient = klienci.FirstOrDefault(x => x.Id == id);
        klienci.Remove(klient);
    }
    public void DodajSamochod(string marka, string model, int rok, int cena, int cenaSprzedazy, bool jestSprzedany)
    {
        var samochod = new Samochod(przypiszId++, marka, model, rok, cena, cenaSprzedazy, jestSprzedany);
        samochody.Add(samochod);
    }

    public void UsunSamochod(int id)
    {
        var samochod = samochody.FirstOrDefault(x => x.Id == id);
        samochody.Remove(samochod);
    }

    public void EdytujKlienta(int id, string imie, string nazwisko, string adres, string numerTelefonu)
    {
        var klient = klienci.FirstOrDefault(x => x.Id == id);
        klient.Imie = imie;
        klient.Nazwisko = nazwisko;
        klient.Adres = adres;
        klient.NumerTelefonu = numerTelefonu;
    }

    public void WyswietlKlientow(ListBox listBox)
    {
        foreach (var klient in klienci)
        {
            listBox.Items.Add(klient);
        }
    }

    public void EdytujSamochod(int id, string marka, string model, int rok, int cena)
    {
        var samochod = samochody.FirstOrDefault(x => x.Id == id);
        samochod.Marka = marka;
        samochod.Model = model;
        samochod.Rok = rok;
        samochod.Cena = cena;
    }

    public void WyswietlSamochody(ListBox listBox)
    {
        foreach (var samochod in samochody)
        {
            listBox.Items.Add(samochod);
        }
    }

    public void WyswietlSamochodyNieSprzedane(ListBox listBox)
    {
        foreach (var samochod in samochody)
        {
            if (!samochod.JestSprzedany)
            {
                listBox.Items.Add(samochod);
            }
        }
    }

    public void WyswietlSamochodySprzedane(ListBox listBox)
    {
        foreach (var samochod in samochody)
        {
            if (samochod.JestSprzedany)
            {
                listBox.Items.Add(samochod);
            }
        }
    }

    public void OznaczJakoSprzedany(int idSamochodu, int idKlienta, int cenaSprzedazy, DateTime dataSprzedazy)
    {
        var samochod = samochody.FirstOrDefault(x => x.Id == idSamochodu);
        var klient = klienci.FirstOrDefault(x => x.Id == idKlienta);
        samochod.JestSprzedany = true;
        samochod.Kupujacy = klient;
        samochod.Sprzedaz = new Sprzedaz(cenaSprzedazy, dataSprzedazy);
    }
}
