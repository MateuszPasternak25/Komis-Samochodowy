using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Komis
{
    public partial class OznJakoSprzedanyForm : Form
    {
        private Zarzadzanie zarzadzanie;
        private Samochod samochod;
        public OznJakoSprzedanyForm(Zarzadzanie zarzadzanie, Samochod samochod)
        {

            this.samochod = samochod;
            this.zarzadzanie = zarzadzanie;
            InitializeComponent();
            zarzadzanie.WyswietlKlientow(ListaKlientow);
        }
        private void ListaKlientow_DoubleClick(object sender, EventArgs e)
        {
            var selectedClient = (Klient)ListaKlientow.SelectedItem;
            textBoxKlientID.Text = selectedClient.Id.ToString();
        }
        private void buttonOznacz_Click(object sender, EventArgs e)
        {
            int idKlienta = int.Parse(textBoxKlientID.Text);
            int cenaSprzedazy = int.Parse(textBoxCenaSprzedazy.Text);
            DateTime dataSprzedazy = dateTimePicker1.Value;

            zarzadzanie.OznaczJakoSprzedany(samochod.Id, idKlienta, cenaSprzedazy, dataSprzedazy);
            this.Close();
        }
    }
}
