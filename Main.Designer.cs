namespace Komis
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListaSamochod = new ListBox();
            samochodBindingSource = new BindingSource(components);
            button1 = new Button();
            textBoxModel = new TextBox();
            textBoxMarka = new TextBox();
            textBoxRok = new TextBox();
            textBoxCenaZakupu = new TextBox();
            textBoxCenaWystawienia = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            checkBoxSprzedane = new CheckBox();
            checkBoxNieSprzedane = new CheckBox();
            KlientForm = new Button();
            ((System.ComponentModel.ISupportInitialize)samochodBindingSource).BeginInit();
            SuspendLayout();
            // 
            // ListaSamochod
            // 
            ListaSamochod.FormattingEnabled = true;
            ListaSamochod.ItemHeight = 15;
            ListaSamochod.Location = new Point(12, 12);
            ListaSamochod.Name = "ListaSamochod";
            ListaSamochod.Size = new Size(1269, 379);
            ListaSamochod.TabIndex = 0;
            ListaSamochod.DoubleClick += ListaSamochod_DoubleClick;
            // 
            // samochodBindingSource
            // 
            samochodBindingSource.DataSource = typeof(Samochod);
            // 
            // button1
            // 
            button1.Location = new Point(542, 414);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxModel
            // 
            textBoxModel.Location = new Point(12, 415);
            textBoxModel.Name = "textBoxModel";
            textBoxModel.Size = new Size(100, 23);
            textBoxModel.TabIndex = 2;
            // 
            // textBoxMarka
            // 
            textBoxMarka.Location = new Point(118, 415);
            textBoxMarka.Name = "textBoxMarka";
            textBoxMarka.Size = new Size(100, 23);
            textBoxMarka.TabIndex = 3;
            // 
            // textBoxRok
            // 
            textBoxRok.Location = new Point(224, 415);
            textBoxRok.Name = "textBoxRok";
            textBoxRok.Size = new Size(100, 23);
            textBoxRok.TabIndex = 4;
            // 
            // textBoxCenaZakupu
            // 
            textBoxCenaZakupu.Location = new Point(330, 415);
            textBoxCenaZakupu.Name = "textBoxCenaZakupu";
            textBoxCenaZakupu.Size = new Size(100, 23);
            textBoxCenaZakupu.TabIndex = 5;
            // 
            // textBoxCenaWystawienia
            // 
            textBoxCenaWystawienia.Location = new Point(436, 415);
            textBoxCenaWystawienia.Name = "textBoxCenaWystawienia";
            textBoxCenaWystawienia.Size = new Size(100, 23);
            textBoxCenaWystawienia.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 397);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 7;
            label1.Text = "Marka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 397);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 8;
            label2.Text = "Model";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(224, 397);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 9;
            label3.Text = "Rok produkcji";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(330, 397);
            label4.Name = "label4";
            label4.Size = new Size(75, 15);
            label4.TabIndex = 10;
            label4.Text = "Cena zakupu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 397);
            label5.Name = "label5";
            label5.Size = new Size(99, 15);
            label5.TabIndex = 11;
            label5.Text = "Cena wystawiona";
            // 
            // checkBoxSprzedane
            // 
            checkBoxSprzedane.AutoSize = true;
            checkBoxSprzedane.Checked = true;
            checkBoxSprzedane.CheckState = CheckState.Checked;
            checkBoxSprzedane.Location = new Point(643, 414);
            checkBoxSprzedane.Name = "checkBoxSprzedane";
            checkBoxSprzedane.Size = new Size(194, 19);
            checkBoxSprzedane.TabIndex = 12;
            checkBoxSprzedane.Text = "Wyświetl sprzedane samochody";
            checkBoxSprzedane.UseVisualStyleBackColor = true;
            checkBoxSprzedane.CheckedChanged += checkBoxSprzedane_CheckedChanged;
            // 
            // checkBoxNieSprzedane
            // 
            checkBoxNieSprzedane.AutoSize = true;
            checkBoxNieSprzedane.Checked = true;
            checkBoxNieSprzedane.CheckState = CheckState.Checked;
            checkBoxNieSprzedane.Location = new Point(843, 414);
            checkBoxNieSprzedane.Name = "checkBoxNieSprzedane";
            checkBoxNieSprzedane.Size = new Size(213, 19);
            checkBoxNieSprzedane.TabIndex = 13;
            checkBoxNieSprzedane.Text = "Wyświetl nie sprzedane samochody";
            checkBoxNieSprzedane.UseVisualStyleBackColor = true;
            checkBoxNieSprzedane.CheckedChanged += checkBoxNieSprzedane_CheckedChanged;
            // 
            // KlientForm
            // 
            KlientForm.Location = new Point(1099, 410);
            KlientForm.Name = "KlientForm";
            KlientForm.Size = new Size(118, 23);
            KlientForm.TabIndex = 14;
            KlientForm.Text = "Zarządzaj klientami";
            KlientForm.UseVisualStyleBackColor = true;
            KlientForm.Click += KlientForm_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 450);
            Controls.Add(KlientForm);
            Controls.Add(checkBoxNieSprzedane);
            Controls.Add(checkBoxSprzedane);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxCenaWystawienia);
            Controls.Add(textBoxCenaZakupu);
            Controls.Add(textBoxRok);
            Controls.Add(textBoxMarka);
            Controls.Add(textBoxModel);
            Controls.Add(button1);
            Controls.Add(ListaSamochod);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)samochodBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListaSamochod;
        private BindingSource samochodBindingSource;
        private Button button1;
        private TextBox textBoxModel;
        private TextBox textBoxMarka;
        private TextBox textBoxRok;
        private TextBox textBoxCenaZakupu;
        private TextBox textBoxCenaWystawienia;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox checkBoxSprzedane;
        private CheckBox checkBoxNieSprzedane;
        private Button KlientForm;
    }
}