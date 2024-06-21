using System;
using System.Collections.Generic;
using System.Linq;

public class Samochod
{
    public int Id { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Rok { get; set; }
    public int Cena { get; set; }
    public int CenaSprzedazy { get; set; }
    public bool JestSprzedany { get; set; }
    public Klient Kupujacy { get; set; }
    public Sprzedaz Sprzedaz { get; set; }

    public Samochod(int id, string marka, string model, int rok, int cena, int cenaSprzedazy, bool jestSprzedany)
    {
        Id = id;
        Marka = marka;
        Model = model;
        Rok = rok;
        Cena = cena;
        CenaSprzedazy = cenaSprzedazy;
        JestSprzedany = false;
    }

    public override string ToString()
    {
        string info = $"{Id} | {Marka} | {Model} | {Rok} |  {Cena} PLN | {CenaSprzedazy} PLN | {(JestSprzedany ? "Sprzedany" : "")}";
        if (JestSprzedany)
        {
            info += $" | Kupujący: {Kupujacy.Imie} {Kupujacy.Nazwisko} | Cena sprzedaży: {Sprzedaz.CenaSprzedazy} PLN | Data sprzedaży: {Sprzedaz.DataSprzedazy.ToShortDateString()}";
        }
        return info;
    }
}

public class Sprzedaz
{
    public int CenaSprzedazy { get; set; }
    public DateTime DataSprzedazy { get; set; }

    public Sprzedaz(int cenaSprzedazy, DateTime dataSprzedazy)
    {
        CenaSprzedazy = cenaSprzedazy;
        DataSprzedazy = dataSprzedazy;
    }
}
public class Klient
{
    public int Id { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Adres { get; set; }
    public string NumerTelefonu { get; set; }



    public Klient(int id, string imie, string nazwisko, string adres, string numerTelefonu)
    {
        Id = id;
        Imie = imie;
        Nazwisko = nazwisko;
        Adres = adres;
        NumerTelefonu = numerTelefonu;
    }

    public override string ToString()
    {
        return $"{Id} | {Imie} | {Nazwisko} | {Adres} | {NumerTelefonu}";

    }
}

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
        if (klient != null)
        {
            klienci.Remove(klient);
        }
        else
        {
            Console.WriteLine($"Nie znaleziono klienta z id {id}");
        }
    }
    public void DodajSamochod(string marka, string model, int rok, int cena, int cenaSprzedazy, bool jestSprzedany)
    {
        var samochod = new Samochod(przypiszId++, marka, model, rok, cena, cenaSprzedazy, jestSprzedany);
        samochody.Add(samochod);
    }

    public void UsunSamochod(int id)
    {
        var samochod = samochody.FirstOrDefault(x => x.Id == id);
        if (samochod != null)
        {
            samochody.Remove(samochod);
        }
        else
        {
            Console.WriteLine($"Nie znaleziono samochodu z id {id}");
        }
    }

    public void EdytujKlienta(int id, string imie, string nazwisko, string adres, string numerTelefonu)
    {
        var klient = klienci.FirstOrDefault(x => x.Id == id);
        if (klient != null)
        {
            klient.Imie = imie;
            klient.Nazwisko = nazwisko;
            klient.Adres = adres;
            klient.NumerTelefonu = numerTelefonu;

        }
        else
        {
            Console.WriteLine($"Nie znaleziono klienta z id {id}");
        }
    }

    public void WyswietlKlientow()
    {
        foreach (var klient in klienci)
        {
            Console.WriteLine(klient);
        }
    }


    public void EdytujSamochod(int id, string marka, string model, int rok, int cena)
    {
        var samochod = samochody.FirstOrDefault(x => x.Id == id);
        if (samochod != null)
        {
            samochod.Marka = marka;
            samochod.Model = model;
            samochod.Rok = rok;
            samochod.Cena = cena;
        }
        else
        {
            Console.WriteLine($"Nie znaleziono samochodu z id {id}");
        }
    }

    public void WyswietlSamochody()
    {
        foreach (var samochod in samochody)
        {
            if (samochod.JestSprzedany == false)
            {
                Console.WriteLine(samochod);
            }
        }
    }

    public void WyswietlSamochodySprzedane()
    {
        foreach (var samochod in samochody)
        {
            if (samochod.JestSprzedany)
            {
                Console.WriteLine(samochod);
            }
        }
    }

    public void WyswietlSamochod(int id)
    {
        var samochod = samochody.FirstOrDefault(x => x.Id == id);

        Console.WriteLine(samochod);

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

class Program
{
    static void Main()
    {

        var zarzadzanie = new Zarzadzanie();

        zarzadzanie.DodajSamochod("BMW", "Seria 3", 2018, 50000, 85000, false);
        zarzadzanie.DodajSamochod("Mercedes-Benz", "Klasa C", 2019, 50000, 110000, false);
        zarzadzanie.DodajSamochod("Audi", "A4", 2017, 50000, 75000, false);
        zarzadzanie.DodajSamochod("Volkswagen", "Golf", 2020, 50000, 70000, false);
        zarzadzanie.DodajSamochod("Ford", "Focus", 2016, 50000, 45000, false);

        zarzadzanie.DodajKlienta("Jan", "Kowalski", "ul. Kwiatowa 5, Warszawa", "+48 501 234 567");
        zarzadzanie.DodajKlienta("Anna", "Nowak", "ul. Leśna 10, Kraków", "+48 600 987 654");
        zarzadzanie.DodajKlienta("Michał", "Wiśniewski", "ul. Słoneczna 3, Gdańsk", "+48 505 321 789");
        zarzadzanie.DodajKlienta("Marta", "Lewandowska", "ul. Polna 8, Wrocław", "+48 515 333 222");
        zarzadzanie.DodajKlienta("Piotr", "Szymański", "ul. Morska 12, Poznań", "+48 510 444 999");


        while (true)
        {
            Console.Clear();
            Console.WriteLine("Wypożyczalnia samochodów");
            Console.WriteLine("1. Klienci");
            Console.WriteLine("2. Samochody");
            Console.WriteLine("3. Wyjdź");
            Console.Write("Wybierz opcję: ");
            var wybor = int.Parse(Console.ReadLine());

            if (wybor == 1)
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Zarządzanie klientami");
                    Console.WriteLine("1. Dodaj klienta");
                    Console.WriteLine("2. Usuń klienta");
                    Console.WriteLine("3. Edytuj klienta");
                    Console.WriteLine("4. Wyświetl listę klientów");
                    Console.WriteLine("5. Powrót do głównego menu");
                    Console.Write("Wybierz opcję: ");
                    var opcja = Console.ReadLine();

                    switch (opcja)
                    {
                        case "1":
                            Console.Clear();
                            DodajKlienta(zarzadzanie);
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Wpisz id klienta, którego chcesz usunąć.");
                            UsunKlienta(zarzadzanie);
                            break;
                        case "3":
                            Console.Clear();
                            Console.WriteLine("Wpisz id klienta, którego chcesz edytować.");
                            EdytujKlienta(zarzadzanie);
                            break;
                        case "4":
                            Console.Clear();
                            zarzadzanie.WyswietlKlientow();
                            break;
                        case "5":
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Wybrano nieprawidłową opcję.");
                            break;
                    }
                }
            }
            else if (wybor == 2)
            {
                Console.Clear();
                while (true)
                {
                    Console.WriteLine("Zarządzanie samochodami");
                    Console.WriteLine("1. Dodaj samochód");
                    Console.WriteLine("2. Usuń samochód");
                    Console.WriteLine("3. Edytuj samochód");
                    Console.WriteLine("4. Wyświetl listę samochodów, które są niesprzedane");
                    Console.WriteLine("5. Oznacz samochód jako sprzedany");
                    Console.WriteLine("6. Wyświetl listę sprzedanych samochodów");
                    Console.WriteLine("7. Powrót do głównego menu");
                    Console.Write("Wybierz opcję: ");
                    var opcja = Console.ReadLine();

                    switch (opcja)
                    {
                        case "1":
                            Console.Clear();
                            DodajSamochod(zarzadzanie);
                            break;
                        case "2":
                            Console.Clear();
                            Console.WriteLine("Wpisz id samochodu, który chcesz usunąć.");
                            UsunSamochod(zarzadzanie);
                            break;
                        case "3":
                            Console.Clear();
                            EdytujSamochod(zarzadzanie);
                            break;
                        case "4":
                            Console.Clear();
                            zarzadzanie.WyswietlSamochody();
                            break;
                        case "5":
                            Console.Clear();
                            zarzadzanie.WyswietlSamochody();
                            OznaczJakoSprzedany(zarzadzanie);
                            break;
                        case "6":
                            Console.Clear();
                            zarzadzanie.WyswietlSamochodySprzedane();
                            break;
                        case "7":
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Wybrano nieprawidłową opcję.");
                            break;
                    }
                }
            }
            else if (wybor == 3)
            {
                break;
            }
        }

        static void OznaczJakoSprzedany(Zarzadzanie zarzadzanie)
        {
            Console.WriteLine("Podaj id samochod, który został sprzedany");
            var idSamochodu = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj id klienta, który zakupił samochód");
            var idKlienta = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj cene sprzedaży");
            var cenaSprzedazy = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj datę sprzedaży (yyyy-mm-dd):");
            DateTime.TryParse(Console.ReadLine(), out DateTime dataSprzedazy);


            zarzadzanie.OznaczJakoSprzedany(idSamochodu, idKlienta, cenaSprzedazy, dataSprzedazy);
        }

        static void DodajKlienta(Zarzadzanie zarzadzanie)
        {
            Console.WriteLine("Podaj imie klienta");
            var imie = Console.ReadLine();
            Console.WriteLine("Podaj nazwisko klienta");
            var nazwisko = Console.ReadLine();
            Console.WriteLine("Podaj adres klienta");
            var adres = Console.ReadLine();
            Console.WriteLine("Podaj numer telefonu klienta");
            var numerTelefonu = Console.ReadLine();

            zarzadzanie.DodajKlienta(imie, nazwisko, adres, numerTelefonu);
        }

        static void UsunKlienta(Zarzadzanie zarzadzanie)
        {
            var id = int.Parse(Console.ReadLine());
            zarzadzanie.UsunKlienta(id);
        }

        static void EdytujKlienta(Zarzadzanie zarzadzanie)
        {
            Console.WriteLine("Podaj id klienta do edycji");
            var id = int.Parse(Console.ReadLine());
            var imie = Console.ReadLine();
            var nazwisko = Console.ReadLine();
            var adres = Console.ReadLine();
            var numerTelefonu = Console.ReadLine();
            zarzadzanie.EdytujKlienta(id, imie, nazwisko, adres, numerTelefonu);
        }

        static void DodajSamochod(Zarzadzanie zarzadzanie)
        {
            Console.WriteLine("Podaj markę samochodu");
            var marka = Console.ReadLine();
            Console.WriteLine("Podaj model samochodu");
            var model = Console.ReadLine();
            Console.WriteLine("Podaj rok produkcji samochodu");
            var rok = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj cena samochodu");
            var cena = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj cena sprzedaży");
            var cenaSprzedazy = int.Parse(Console.ReadLine());
            var jestSprzedany = false;

            zarzadzanie.DodajSamochod(marka, model, rok, cena, cenaSprzedazy, jestSprzedany);
        }

        static void UsunSamochod(Zarzadzanie zarzadzanie)
        {
            var id = int.Parse(Console.ReadLine());
            zarzadzanie.UsunSamochod(id);
        }

        static void EdytujSamochod(Zarzadzanie zarzadzanie)
        {
            Console.Clear();
            Console.WriteLine("Podaj id samochodu do edycji");
            var id = int.Parse(Console.ReadLine());
            zarzadzanie.WyswietlSamochod(id);
            Console.WriteLine("Podaj markę samochodu: ");
            var marka = Console.ReadLine();
            Console.WriteLine("Podaj model samochodu: ");
            var model = Console.ReadLine();
            Console.WriteLine("Podaj rok produkcji: ");
            var rok = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj cene samochodu: ");
            var cena = int.Parse(Console.ReadLine());
            zarzadzanie.EdytujSamochod(id, marka, model, rok, cena);
        }
    }
}
