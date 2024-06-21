namespace WindowsFormsApp2
{
    partial class AddKlientForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtImie;
        private System.Windows.Forms.TextBox txtNazwisko;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Button btnDodaj;

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
            this.txtImie = new System.Windows.Forms.TextBox();
            this.txtNazwisko = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtImie
            // 
            this.txtImie.Location = new System.Drawing.Point(12, 12);
            this.txtImie.Name = "txtImie";
            this.txtImie.Size = new System.Drawing.Size(100, 20);
            this.txtImie.TabIndex = 0;
            // 
            // txtNazwisko
            // 
            this.txtNazwisko.Location = new System.Drawing.Point(12, 38);
            this.txtNazwisko.Name = "txtNazwisko";
            this.txtNazwisko.Size = new System.Drawing.Size(100, 20);
            this.txtNazwisko.TabIndex = 1;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(12, 64);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(100, 20);
            this.txtAdres.TabIndex = 2;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(12, 90);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 20);
            this.txtTelefon.TabIndex = 3;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 116);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 23);
            this.btnDodaj.TabIndex = 4;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // AddKlientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 151);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtNazwisko);
            this.Controls.Add(this.txtImie);
            this.Name = "AddKlientForm";
            this.Text = "Dodaj Klienta";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
