namespace Komis
{
    public partial class ZarzadzajKlientemForm : Form
    {

        private Zarzadzanie zarzadzanie;
        public ZarzadzajKlientemForm(Zarzadzanie zarzadzanie)
        {
            this.zarzadzanie = zarzadzanie;
            InitializeComponent();
            zarzadzanie.WyswietlKlientow(ListaKlientow);
        }
        private void OdswiezKlientow()
        {
            ListaKlientow.Items.Clear();
            zarzadzanie.WyswietlKlientow(ListaKlientow);
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {

            var imie = textBoxImie.Text;
            var nazwisko = textBoxNazwisko.Text;
            var adres = textBoxAdres.Text;
            var numer = textBoxNumer.Text;

            zarzadzanie.DodajKlienta(imie, nazwisko, adres, numer);
            textBoxImie.Text = "";
            textBoxNazwisko.Text = "";
            textBoxAdres.Text = "";
            textBoxNumer.Text = "";
            OdswiezKlientow();
        }
        private void edytujKlient_FormClosed(object sender, FormClosedEventArgs e)
        {
            OdswiezKlientow();
        }
        private void ListaKlientow_DoubleClick(object sender, EventArgs e)
        {
            if (ListaKlientow.SelectedItem != null)
            {
                var wybranyKlient = (Klient)ListaKlientow.SelectedItem;
                EdytujKlient edytujKlient = new EdytujKlient(wybranyKlient, zarzadzanie);
                edytujKlient.FormClosed += edytujKlient_FormClosed;
                edytujKlient.Show();
            }
        }
    }
}
