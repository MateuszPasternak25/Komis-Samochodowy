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
    public partial class AddKlientForm : Form
    {
        private Zarzadzanie zarzadzanie;

        public AddKlientForm(Zarzadzanie zarzadzanie)
        {
            InitializeComponent();
            this.zarzadzanie = zarzadzanie;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string imie = txtImie.Text;
            string nazwisko = txtNazwisko.Text;
            string adres = txtAdres.Text;
            string telefon = txtTelefon.Text;

            zarzadzanie.DodajKlienta(imie, nazwisko, adres, telefon);
            this.Close();
        }

        private void AddKlientForm_Load(object sender, EventArgs e)
        {

        }
    }
}
