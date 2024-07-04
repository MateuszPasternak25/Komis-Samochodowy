using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

public class Zarzadzanie
{
    List<Klient> klienci;
    List<Samochod> samochody;
    private int przypiszId, przypiszIdKlienta;

    public Zarzadzanie()
    {
        klienci = new List<Klient>();
        samochody = new List<Samochod>();
        przypiszId = 1;
        przypiszIdKlienta = 1;
        WczytajDaneZPliku();
    }

    public void DodajKlienta(string imie, string nazwisko, string adres, string numerTelefonu)
    {
        var klient = new Klient(przypiszIdKlienta++, imie, nazwisko, adres, numerTelefonu);
        klienci.Add(klient);
        ZapiszDane();
    }

    public void UsunKlienta(int id)
    {
        var klient = klienci.FirstOrDefault(x => x.Id == id);
        klienci.Remove(klient);
        ZapiszDane();
    }
    public void DodajSamochod(string marka, string model, int rok, int cena, int cenaSprzedazy, bool jestSprzedany)
    {
        var samochod = new Samochod(przypiszId++, marka, model, rok, cena, cenaSprzedazy, jestSprzedany);
        samochody.Add(samochod);
        ZapiszDane();
    }

    public void UsunSamochod(int id)
    {
        var samochod = samochody.FirstOrDefault(x => x.Id == id);
        samochody.Remove(samochod);
        ZapiszDane();
    }

    public void EdytujKlienta(int id, string imie, string nazwisko, string adres, string numerTelefonu)
    {
        var klient = klienci.FirstOrDefault(x => x.Id == id);
        klient.Imie = imie;
        klient.Nazwisko = nazwisko;
        klient.Adres = adres;
        klient.NumerTelefonu = numerTelefonu;
        ZapiszDane();
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

        ZapiszDane();
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
        ZapiszDane();
    }

    public void ZapiszDane()
    {
        var daneDoZapisu = new { Klienci = klienci, Samochody = samochody };
        string json = JsonConvert.SerializeObject(daneDoZapisu, Formatting.Indented);

        File.WriteAllText(@"Dane.json", json);
    }

    private void WczytajDaneZPliku()
    {
        if (File.Exists(@"Dane.json") && new FileInfo(@"Dane.json").Length > 0)
        {
            string json = File.ReadAllText(@"Dane.json");

            var daneZPliku = JsonConvert.DeserializeObject<JObject>(json);

            klienci = daneZPliku["Klienci"]?.ToObject<List<Klient>>() ?? new List<Klient>();
            samochody = daneZPliku["Samochody"]?.ToObject<List<Samochod>>() ?? new List<Samochod>();

            przypiszIdKlienta = klienci.Any() ? klienci.Max(k => k.Id) + 1 : 1;
            przypiszId = samochody.Any() ? samochody.Max(x => x.Id) + 1 : 1;

        }
        else
        {
            klienci = new List<Klient>();
            samochody = new List<Samochod>();
        }
    }
}

