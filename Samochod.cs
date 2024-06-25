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
            info += $" | Kupuj¹cy: {Kupujacy.Imie} {Kupujacy.Nazwisko} | Cena sprzeda¿y: {Sprzedaz.CenaSprzedazy} PLN | Data sprzeda¿y: {Sprzedaz.DataSprzedazy.ToShortDateString()}";
        }
        return info;
    }
}
