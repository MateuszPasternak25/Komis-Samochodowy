namespace WindowsFormsApp2
{
    partial class AddSamochodForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtMarka;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtRocznik;
        private System.Windows.Forms.TextBox txtPrzebieg;
        private System.Windows.Forms.TextBox txtCena;
        private System.Windows.Forms.CheckBox chkCzySprzedany;
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
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtRocznik = new System.Windows.Forms.TextBox();
            this.txtPrzebieg = new System.Windows.Forms.TextBox();
            this.txtCena = new System.Windows.Forms.TextBox();
            this.chkCzySprzedany = new System.Windows.Forms.CheckBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMarka
            // 
            this.txtMarka.Location = new System.Drawing.Point(12, 12);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(100, 20);
            this.txtMarka.TabIndex = 0;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(12, 38);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 1;
            // 
            // txtRocznik
            // 
            this.txtRocznik.Location = new System.Drawing.Point(12, 64);
            this.txtRocznik.Name = "txtRocznik";
            this.txtRocznik.Size = new System.Drawing.Size(100, 20);
            this.txtRocznik.TabIndex = 2;
            // 
            // txtPrzebieg
            // 
            this.txtPrzebieg.Location = new System.Drawing.Point(12, 90);
            this.txtPrzebieg.Name = "txtPrzebieg";
            this.txtPrzebieg.Size = new System.Drawing.Size(100, 20);
            this.txtPrzebieg.TabIndex = 3;
            // 
            // txtCena
            // 
            this.txtCena.Location = new System.Drawing.Point(12, 116);
            this.txtCena.Name = "txtCena";
            this.txtCena.Size = new System.Drawing.Size(100, 20);
            this.txtCena.TabIndex = 4;
            // 
            // chkCzySprzedany
            // 
            this.chkCzySprzedany.AutoSize = true;
            this.chkCzySprzedany.Location = new System.Drawing.Point(12, 142);
            this.chkCzySprzedany.Name = "chkCzySprzedany";
            this.chkCzySprzedany.Size = new System.Drawing.Size(96, 17);
            this.chkCzySprzedany.TabIndex = 5;
            this.chkCzySprzedany.Text = "Czy Sprzedany";
            this.chkCzySprzedany.UseVisualStyleBackColor = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(12, 165);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(100, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // AddSamochodForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(128, 200);
            this.Controls.Add(this.btnDodaj);
            this.Controls.Add(this.chkCzySprzedany);
            this.Controls.Add(this.txtCena);
            this.Controls.Add(this.txtPrzebieg);
            this.Controls.Add(this.txtRocznik);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.txtMarka);
            this.Name = "AddSamochodForm";
            this.Text = "Dodaj Samochód";
            this.Load += new System.EventHandler(this.AddSamochodForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
