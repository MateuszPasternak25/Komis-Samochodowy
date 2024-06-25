using System.Reflection;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Komis
{
    public partial class Form1 : Form
    {
        private Zarzadzanie zarzadzanie;
        public Form1()
        {
            zarzadzanie = new Zarzadzanie();
            InitializeComponent();
            dodajDane();
            OdswiezListeSamochodow();
        }

        private void dodajDane()
        {
            zarzadzanie.DodajSamochod("BMW", "Seria 3", 2018, 50000, 85000, false);
            zarzadzanie.DodajSamochod("Mercedes-Benz", "Klasa C", 2019, 50000, 110000, false);
            zarzadzanie.DodajSamochod("Audi", "A4", 2017, 50000, 75000, false);
            zarzadzanie.DodajSamochod("Volkswagen", "Golf", 2020, 50000, 70000, false);
            zarzadzanie.DodajSamochod("Ford", "Focus", 2016, 50000, 45000, false);

            zarzadzanie.DodajKlienta("Jan", "Kowalski", "Kwiatowa 5, Warszawa", "+48 501 234 567");
            zarzadzanie.DodajKlienta("Anna", "Nowak", "Leœna 10, Kraków", "+48 600 987 654");
            zarzadzanie.DodajKlienta("Micha³", "Wiœniewski", "S³oneczna 3, Gdañsk", "+48 505 321 789");
            zarzadzanie.DodajKlienta("Marta", "Lewandowska", "Polna 8, Wroc³aw", "+48 515 333 222");
            zarzadzanie.DodajKlienta("Piotr", "Szymañski", "Morska 12, Poznañ", "+48 510 444 999");

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

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