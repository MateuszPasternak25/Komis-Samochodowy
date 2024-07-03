using System;
using System.Collections.Generic;
using System.Linq;
public class Samochod : Pojazd
{
    public int CenaSprzedazy { get; set; }
    public bool JestSprzedany { get; set; }
    public Klient Kupujacy { get; set; }
    public Sprzedaz Sprzedaz { get; set; }

    public Samochod(int id, string marka, string model, int rok, int cena, int cenaSprzedazy, bool jestSprzedany)
        : base(id, marka, model, rok, cena)
    {
        CenaSprzedazy = cenaSprzedazy;
        JestSprzedany = jestSprzedany;
    }

    public override string ToString()
    {
        string info = $"{base.ToString()} | {CenaSprzedazy} PLN | {(JestSprzedany ? "Sprzedany" : "")}";
        if (JestSprzedany)
        {
            info += $" | Kupuj¹cy: {Kupujacy.Imie} {Kupujacy.Nazwisko} | Cena sprzeda¿y: {Sprzedaz.CenaSprzedazy} PLN | Data sprzeda¿y: {Sprzedaz.DataSprzedazy.ToShortDateString()}";
        }
        return info;
    }
}