namespace Komis
{
    public partial class Form1 : Form
    {
        private Zarzadzanie zarzadzanie;
        public Form1()
        {
            zarzadzanie = new Zarzadzanie();
            InitializeComponent();
            OdswiezListeSamochodow();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var marka = textBoxMarka.Text;
            var model = textBoxModel.Text;
            var rok = int.Parse(textBoxRok.Text);
            var cena = int.Parse(textBoxCenaZakupu.Text);
            var cenaSprzedazy = int.Parse(textBoxCenaWystawienia.Text);
            var jestSprzedany = false;

            zarzadzanie.DodajSamochod(marka, model, rok, cena, cenaSprzedazy, jestSprzedany);
            textBoxMarka.Text = "";
            textBoxModel.Text = "";
            textBoxRok.Text = "";
            textBoxCenaZakupu.Text = "";
            textBoxCenaWystawienia.Text = "";
            OdswiezListeSamochodow();
        }
        private void OdswiezListeSamochodow()
        {
            ListaSamochod.Items.Clear();
            if (checkBoxSprzedane.Checked && !checkBoxNieSprzedane.Checked)
            {
                zarzadzanie.WyswietlSamochodySprzedane(ListaSamochod);
            }
            else if (checkBoxNieSprzedane.Checked && checkBoxSprzedane.Checked)
            {
                zarzadzanie.WyswietlSamochody(ListaSamochod);
            }
            else if (!checkBoxSprzedane.Checked && checkBoxNieSprzedane.Checked)
            {
                zarzadzanie.WyswietlSamochodyNieSprzedane(ListaSamochod);
            }
        }
        private void ListaSamochod_DoubleClick(object sender, EventArgs e)
        {
            if(ListaSamochod.SelectedItem != null) { 
            var selectedCar = (Samochod)ListaSamochod.SelectedItem;
            EdytujSamochodForm edytujSamochod = new EdytujSamochodForm(selectedCar, zarzadzanie);
            edytujSamochod.FormClosed += EdytujSamochodForm_FormClosed;
            edytujSamochod.Show();
            }
        }
        private void EdytujSamochodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            OdswiezListeSamochodow();
        }
        private void checkBoxNieSprzedane_CheckedChanged(object sender, EventArgs e)
        {
            ListaSamochod.Items.Clear();
            OdswiezListeSamochodow();
        }
        private void checkBoxSprzedane_CheckedChanged(object sender, EventArgs e)
        {
            ListaSamochod.Items.Clear();
            OdswiezListeSamochodow();
        }
        private void KlientForm_Click(object sender, EventArgs e)
        {
            ZarzadzajKlientemForm zarzadzajKlientem = new ZarzadzajKlientemForm(zarzadzanie);
            zarzadzajKlientem.Show();
        }
    }
}