namespace Komis
{
    partial class EdytujSamochodForm
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
            textBoxMarkaE = new TextBox();
            textBoxModelE = new TextBox();
            textBoxRokE = new TextBox();
            textBoxCenaE = new TextBox();
            textBoxCenaWE = new TextBox();
            ZapiszButton = new Button();
            ButtonUsun = new Button();
            OznaczJakoSprzedanyButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBoxMarkaE
            // 
            textBoxMarkaE.Location = new Point(37, 21);
            textBoxMarkaE.Name = "textBoxMarkaE";
            textBoxMarkaE.Size = new Size(100, 23);
            textBoxMarkaE.TabIndex = 0;
            // 
            // textBoxModelE
            // 
            textBoxModelE.Location = new Point(143, 20);
            textBoxModelE.Name = "textBoxModelE";
            textBoxModelE.Size = new Size(100, 23);
            textBoxModelE.TabIndex = 1;
            // 
            // textBoxRokE
            // 
            textBoxRokE.Location = new Point(249, 21);
            textBoxRokE.Name = "textBoxRokE";
            textBoxRokE.Size = new Size(100, 23);
            textBoxRokE.TabIndex = 2;
            // 
            // textBoxCenaE
            // 
            textBoxCenaE.Location = new Point(355, 21);
            textBoxCenaE.Name = "textBoxCenaE";
            textBoxCenaE.Size = new Size(100, 23);
            textBoxCenaE.TabIndex = 3;
            // 
            // textBoxCenaWE
            // 
            textBoxCenaWE.Location = new Point(461, 21);
            textBoxCenaWE.Name = "textBoxCenaWE";
            textBoxCenaWE.Size = new Size(100, 23);
            textBoxCenaWE.TabIndex = 4;
            // 
            // ZapiszButton
            // 
            ZapiszButton.Location = new Point(37, 60);
            ZapiszButton.Name = "ZapiszButton";
            ZapiszButton.Size = new Size(75, 23);
            ZapiszButton.TabIndex = 5;
            ZapiszButton.Text = "Zapisz";
            ZapiszButton.UseVisualStyleBackColor = true;
            ZapiszButton.Click += ZapiszButton_Click;
            // 
            // ButtonUsun
            // 
            ButtonUsun.Location = new Point(486, 60);
            ButtonUsun.Name = "ButtonUsun";
            ButtonUsun.Size = new Size(75, 23);
            ButtonUsun.TabIndex = 6;
            ButtonUsun.Text = "Usuń";
            ButtonUsun.UseVisualStyleBackColor = true;
            ButtonUsun.Click += button1_Click;
            // 
            // OznaczJakoSprzedanyButton
            // 
            OznaczJakoSprzedanyButton.Location = new Point(118, 60);
            OznaczJakoSprzedanyButton.Name = "OznaczJakoSprzedanyButton";
            OznaczJakoSprzedanyButton.Size = new Size(135, 23);
            OznaczJakoSprzedanyButton.TabIndex = 7;
            OznaczJakoSprzedanyButton.Text = "Oznacz jako sprzedany";
            OznaczJakoSprzedanyButton.UseVisualStyleBackColor = true;
            OznaczJakoSprzedanyButton.Click += button1_Click_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(72, 3);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 8;
            label1.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 3);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 9;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(287, 3);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 10;
            label3.Text = "Rok";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 3);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 11;
            label4.Text = "Cena kupna";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(461, 3);
            label5.Name = "label5";
            label5.Size = new Size(101, 15);
            label5.TabIndex = 12;
            label5.Text = "Cena wystawienia";
            // 
            // EdytujSamochodForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(OznaczJakoSprzedanyButton);
            Controls.Add(ButtonUsun);
            Controls.Add(ZapiszButton);
            Controls.Add(textBoxCenaWE);
            Controls.Add(textBoxCenaE);
            Controls.Add(textBoxRokE);
            Controls.Add(textBoxModelE);
            Controls.Add(textBoxMarkaE);
            Name = "EdytujSamochodForm";
            Text = "EdytujSamochodForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxMarkaE;
        private TextBox textBoxModelE;
        private TextBox textBoxRokE;
        private TextBox textBoxCenaE;
        private TextBox textBoxCenaWE;
        private Button ZapiszButton;
        private Button ButtonUsun;
        private Button OznaczJakoSprzedanyButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}