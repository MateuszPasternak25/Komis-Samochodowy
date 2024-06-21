using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        private Zarzadzanie zarzadzanie;

        public MainForm()
        {
            InitializeComponent();
            zarzadzanie = new Zarzadzanie();
        }

        private void btnDodajSamochod_Click(object sender, EventArgs e)
        {
            AddSamochodForm addSamochodForm = new AddSamochodForm(zarzadzanie);
            addSamochodForm.ShowDialog();
            OdswiezListeSamochodow();
        }

        private void btnDodajKlienta_Click(object sender, EventArgs e)
        {
            AddKlientForm addKlientForm = new AddKlientForm(zarzadzanie);
            addKlientForm.ShowDialog();
            OdswiezListeKlientow();
        }

        private void OdswiezListeSamochodow()
        {
            listViewSamochody.Items.Clear();
            foreach (var samochod in zarzadzanie.PobierzSamochody())
            {
                var item = new ListViewItem(new[] { samochod.Marka, samochod.Model, samochod.Rocznik.ToString(), samochod.Przebieg.ToString(), samochod.Cena.ToString() });
                listViewSamochody.Items.Add(item);
            }
        }

        private void OdswiezListeKlientow()
        {
            listViewKlienci.Items.Clear();
            foreach (var klient in zarzadzanie.PobierzKlientow())
            {
                var item = new ListViewItem(new[] { klient.Imie, klient.Nazwisko, klient.Adres, klient.Telefon });
                listViewKlienci.Items.Add(item);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
