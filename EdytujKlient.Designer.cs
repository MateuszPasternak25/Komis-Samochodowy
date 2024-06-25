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
            textBoxAdresE.Size = new Size(100, 23);
            textBoxAdresE.TabIndex = 2;
            // 
            // textBoxNumerE
            // 
            textBoxNumerE.Location = new Point(333, 36);
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
            Usun.Location = new Point(358, 65);
            Usun.Name = "Usun";
            Usun.Size = new Size(75, 23);
            Usun.TabIndex = 5;
            Usun.Text = "Usuń";
            Usun.UseVisualStyleBackColor = true;
            Usun.Click += Usun_Click;
            // 
            // EdytujKlient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Usun);
            Controls.Add(Zapisz);
            Controls.Add(textBoxNumerE);
            Controls.Add(textBoxAdresE);
            Controls.Add(textBoxNazwiskoE);
            Controls.Add(textBoxImieE);
            Name = "EdytujKlient";
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
    }
}