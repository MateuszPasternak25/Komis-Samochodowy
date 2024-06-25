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