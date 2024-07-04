namespace Komis
{
    public partial class EdytujSamochodForm : Form
    {
        private Samochod samochod;
        private Zarzadzanie zarzadzanie;
        public EdytujSamochodForm(Samochod samochod, Zarzadzanie zarzadzanie)
        {
            InitializeComponent();
            this.samochod = samochod;
            this.zarzadzanie = zarzadzanie;
            LoadSamochodData();
        }
        private void LoadSamochodData()
        {
            textBoxMarkaE.Text = samochod.Marka;
            textBoxModelE.Text = samochod.Model;
            textBoxRokE.Text = samochod.Rok.ToString();
            textBoxCenaE.Text = samochod.Cena.ToString();
            textBoxCenaWE.Text = samochod.CenaSprzedazy.ToString();
        }
        private void SaveSamochodData()
        {
            samochod.Marka = textBoxMarkaE.Text;
            samochod.Model = textBoxModelE.Text;
            samochod.Rok = int.Parse(textBoxRokE.Text);
            samochod.Cena = int.Parse(textBoxCenaE.Text);
            samochod.CenaSprzedazy = int.Parse(textBoxCenaWE.Text);
        }
        private void ZapiszButton_Click(object sender, EventArgs e)
        {
            SaveSamochodData();
            Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            zarzadzanie.UsunSamochod(samochod.Id);
            Close();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OznJakoSprzedanyForm oznJakoSprzedany = new OznJakoSprzedanyForm(zarzadzanie, samochod);
            oznJakoSprzedany.Show();
        }
    }
}
