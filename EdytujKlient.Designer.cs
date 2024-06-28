namespace Komis
{
    partial class EdytujKlient
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
            textBoxImieE = new TextBox();
            textBoxNazwiskoE = new TextBox();
            textBoxAdresE = new TextBox();
            textBoxNumerE = new TextBox();
            Zapisz = new Button();
            Usun = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBoxImieE
            // 
            textBoxImieE.Location = new Point(15, 36);
            textBoxImieE.Name = "textBoxImieE";
            textBoxImieE.Size = new Size(100, 23);
            textBoxImieE.TabIndex = 0;
            // 
            // textBoxNazwiskoE
            // 
            textBoxNazwiskoE.Location = new Point(121, 36);
            textBoxNazwiskoE.Name = "textBoxNazwiskoE";
            textBoxNazwiskoE.Size = new Size(100, 23);
            textBoxNazwiskoE.TabIndex = 1;
            // 
            // textBoxAdresE
            // 
            textBoxAdresE.Location = new Point(227, 36);
            textBoxAdresE.Name = "textBoxAdresE";
            textBoxAdresE.Size = new Size(192, 23);
            textBoxAdresE.TabIndex = 2;
            // 
            // textBoxNumerE
            // 
            textBoxNumerE.Location = new Point(425, 36);
            textBoxNumerE.Name = "textBoxNumerE";
            textBoxNumerE.Size = new Size(100, 23);
            textBoxNumerE.TabIndex = 3;
            // 
            // Zapisz
            // 
            Zapisz.Location = new Point(15, 65);
            Zapisz.Name = "Zapisz";
            Zapisz.Size = new Size(75, 23);
            Zapisz.TabIndex = 4;
            Zapisz.Text = "Zapisz";
            Zapisz.UseVisualStyleBackColor = true;
            Zapisz.Click += Zapisz_Click;
            // 
            // Usun
            // 
            Usun.Location = new Point(450, 65);
            Usun.Name = "Usun";
            Usun.Size = new Size(75, 23);
            Usun.TabIndex = 5;
            Usun.Text = "Usuń";
            Usun.UseVisualStyleBackColor = true;
            Usun.Click += Usun_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 18);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 6;
            label1.Text = "Imię";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(121, 18);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 7;
            label2.Text = "Nazwisko";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(227, 18);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 8;
            label3.Text = "Adres";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(434, 18);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 9;
            label4.Text = "Numer telefonu";
            // 
            // EdytujKlient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(545, 110);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Usun);
            Controls.Add(Zapisz);
            Controls.Add(textBoxNumerE);
            Controls.Add(textBoxAdresE);
            Controls.Add(textBoxNazwiskoE);
            Controls.Add(textBoxImieE);
            Name = "EdytujKlient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EdytujKlient";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxImieE;
        private TextBox textBoxNazwiskoE;
        private TextBox textBoxAdresE;
        private TextBox textBoxNumerE;
        private Button Zapisz;
        private Button Usun;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}