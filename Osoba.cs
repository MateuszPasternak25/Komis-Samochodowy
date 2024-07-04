public class Osoba
{
    public int Id { get; set; }
    public string Imie { get; set; }
    public string Nazwisko { get; set; }
    public string Adres { get; set; }
    public string NumerTelefonu { get; set; }

    public Osoba(int id, string imie, string nazwisko, string adres, string numerTelefonu)
    {
        Id = id;
        Imie = imie;
        Nazwisko = nazwisko;
        Adres = adres;
        NumerTelefonu = numerTelefonu;
    }
    public override string ToString()
    {
        return $"{Id} | {Imie} | {Nazwisko} | ul. {Adres} | {NumerTelefonu}";
    }
}