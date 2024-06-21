namespace WindowsFormsApp2
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button btnDodajSamochod;
        private System.Windows.Forms.Button btnDodajKlienta;
        private System.Windows.Forms.ListView listViewSamochody;
        private System.Windows.Forms.ListView listViewKlienci;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnDodajSamochod = new System.Windows.Forms.Button();
            this.btnDodajKlienta = new System.Windows.Forms.Button();
            this.listViewSamochody = new System.Windows.Forms.ListView();
            this.listViewKlienci = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btnDodajSamochod
            // 
            this.btnDodajSamochod.Location = new System.Drawing.Point(12, 12);
            this.btnDodajSamochod.Name = "btnDodajSamochod";
            this.btnDodajSamochod.Size = new System.Drawing.Size(100, 23);
            this.btnDodajSamochod.TabIndex = 0;
            this.btnDodajSamochod.Text = "Dodaj Samochód";
            this.btnDodajSamochod.UseVisualStyleBackColor = true;
            this.btnDodajSamochod.Click += new System.EventHandler(this.btnDodajSamochod_Click);
            // 
            // btnDodajKlienta
            // 
            this.btnDodajKlienta.Location = new System.Drawing.Point(12, 41);
            this.btnDodajKlienta.Name = "btnDodajKlienta";
            this.btnDodajKlienta.Size = new System.Drawing.Size(100, 23);
            this.btnDodajKlienta.TabIndex = 1;
            this.btnDodajKlienta.Text = "Dodaj Klienta";
            this.btnDodajKlienta.UseVisualStyleBackColor = true;
            this.btnDodajKlienta.Click += new System.EventHandler(this.btnDodajKlienta_Click);
            // 
            // listViewSamochody
            // 
            this.listViewSamochody.HideSelection = false;
            this.listViewSamochody.Location = new System.Drawing.Point(12, 70);
            this.listViewSamochody.Name = "listViewSamochody";
            this.listViewSamochody.Size = new System.Drawing.Size(776, 150);
            this.listViewSamochody.TabIndex = 2;
            this.listViewSamochody.UseCompatibleStateImageBehavior = false;
            // 
            // listViewKlienci
            // 
            this.listViewKlienci.HideSelection = false;
            this.listViewKlienci.Location = new System.Drawing.Point(12, 226);
            this.listViewKlienci.Name = "listViewKlienci";
            this.listViewKlienci.Size = new System.Drawing.Size(776, 150);
            this.listViewKlienci.TabIndex = 3;
            this.listViewKlienci.UseCompatibleStateImageBehavior = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listViewKlienci);
            this.Controls.Add(this.listViewSamochody);
            this.Controls.Add(this.btnDodajKlienta);
            this.Controls.Add(this.btnDodajSamochod);
            this.Name = "MainForm";
            this.Text = "Zarządzanie Samochodami";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }
    }
}
