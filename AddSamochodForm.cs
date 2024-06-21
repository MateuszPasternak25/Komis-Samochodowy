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
    public partial class AddSamochodForm : Form
    {
        private Zarzadzanie zarzadzanie;

        public AddSamochodForm(Zarzadzanie zarzadzanie)
        {
            InitializeComponent();
            this.zarzadzanie = zarzadzanie;
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            string marka = txtMarka.Text;
            string model = txtModel.Text;
            int rocznik = int.Parse(txtRocznik.Text);
            int przebieg = int.Parse(txtPrzebieg.Text);
            decimal cena = decimal.Parse(txtCena.Text);
            bool czySprzedany = chkCzySprzedany.Checked;

            zarzadzanie.DodajSamochod(marka, model, rocznik, przebieg, cena, czySprzedany);
            this.Close();
        }

        private void AddSamochodForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
