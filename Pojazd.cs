public class Pojazd
{
    public int Id { get; set; }
    public string Marka { get; set; }
    public string Model { get; set; }
    public int Rok { get; set; }
    public int Cena { get; set; }

    public Pojazd(int id, string marka, string model, int rok, int cena)
    {
        Id = id;
        Marka = marka;
        Model = model;
        Rok = rok;
        Cena = cena;
    }

    public override string ToString()
    {
        return $"{Id} | {Marka} | {Model} | {Rok} | {Cena} PLN";
    }
}
