namespace Komis
{
    public partial class EdytujKlient : Form
    {
        private Klient klient;
        private Zarzadzanie zarzadzanie;
        public EdytujKlient(Klient klient, Zarzadzanie zarzadzanie)
        {
            this.klient = klient;
            this.zarzadzanie = zarzadzanie;
            InitializeComponent();
            LoadSamochodData();
        }
        private void ZapiszZmiany()
        {
            klient.Imie = textBoxImieE.Text;
            klient.Nazwisko = textBoxNazwiskoE.Text;
            klient.Adres = textBoxAdresE.Text;
            klient.NumerTelefonu = textBoxNumerE.Text;
        }
        private void LoadSamochodData()
        {
            textBoxImieE.Text = klient.Imie;
            textBoxNazwiskoE.Text = klient.Nazwisko;
            textBoxAdresE.Text = klient.Adres;
            textBoxNumerE.Text = klient.NumerTelefonu;

        }
        private void Zapisz_Click(object sender, EventArgs e)
        {
            ZapiszZmiany();
            Close();
        }
        private void Usun_Click(object sender, EventArgs e)
        {
            zarzadzanie.UsunKlienta(klient.Id);
            Close();
        }
    }
}
