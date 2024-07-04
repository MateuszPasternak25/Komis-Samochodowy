namespace Komis
{
    partial class ZarzadzajKlientemForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListaKlientow = new ListBox();
            textBoxImie = new TextBox();
            textBoxNazwisko = new TextBox();
            textBoxAdres = new TextBox();
            textBoxNumer = new TextBox();
            Dodaj = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // ListaKlientow
            // 
            ListaKlientow.FormattingEnabled = true;
            ListaKlientow.ItemHeight = 15;
            ListaKlientow.Location = new Point(12, 12);
            ListaKlientow.Name = "ListaKlientow";
            ListaKlientow.Size = new Size(776, 349);
            ListaKlientow.TabIndex = 0;
            ListaKlientow.DoubleClick += ListaKlientow_DoubleClick;
            // 
            // textBoxImie
            // 
            textBoxImie.Location = new Point(12, 395);
            textBoxImie.Name = "textBoxImie";
            textBoxImie.Size = new Size(100, 23);
            textBoxImie.TabIndex = 1;
            // 
            // textBoxNazwisko
            // 
            textBoxNazwisko.Location = new Point(118, 395);
            textBoxNazwisko.Name = "textBoxNazwisko";
            textBoxNazwisko.Size = new Size(100, 23);
            textBoxNazwisko.TabIndex = 2;
            // 
            // textBoxAdres
            // 
            textBoxAdres.Location = new Point(224, 395);
            textBoxAdres.Name = "textBoxAdres";
            textBoxAdres.Size = new Size(100, 23);
            textBoxAdres.TabIndex = 3;
            // 
            // textBoxNumer
            // 
            textBoxNumer.Location = new Point(330, 395);
            textBoxNumer.Name = "textBoxNumer";
            textBoxNumer.Size = new Size(100, 23);
            textBoxNumer.TabIndex = 4;
            // 
            // Dodaj
            // 
            Dodaj.Location = new Point(713, 394);
            Dodaj.Name = "Dodaj";
            Dodaj.Size = new Size(75, 23);
            Dodaj.TabIndex = 5;
            Dodaj.Text = "Dodaj";
            Dodaj.UseVisualStyleBackColor = true;
            Dodaj.Click += Dodaj_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 377);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 6;
            label1.Text = "Imie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 377);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 375);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 8;
            label3.Text = "Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 377);
            label4.Name = "label4";
            label4.Size = new Size(92, 15);
            label4.TabIndex = 9;
            label4.Text = "Numer Telefonu";
            // 
            // ZarzadzajKlientemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Dodaj);
            Controls.Add(textBoxNumer);
            Controls.Add(textBoxAdres);
            Controls.Add(textBoxNazwisko);
            Controls.Add(textBoxImie);
            Controls.Add(ListaKlientow);
            Name = "ZarzadzajKlientemForm";
            Text = "ZarzadzajKlientem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListaKlientow;
        private TextBox textBoxImie;
        private TextBox textBoxNazwisko;
        private TextBox textBoxAdres;
        private TextBox textBoxNumer;
        private Button Dodaj;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}