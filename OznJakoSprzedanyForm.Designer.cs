namespace Komis
{
    partial class OznJakoSprzedanyForm
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
            textBoxCenaSprzedazy = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            ListaKlientow = new ListBox();
            textBoxKlientID = new TextBox();
            buttonOznacz = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxCenaSprzedazy
            // 
            textBoxCenaSprzedazy.Location = new Point(130, 415);
            textBoxCenaSprzedazy.Name = "textBoxCenaSprzedazy";
            textBoxCenaSprzedazy.Size = new Size(100, 23);
            textBoxCenaSprzedazy.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(252, 415);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // ListaKlientow
            // 
            ListaKlientow.FormattingEnabled = true;
            ListaKlientow.ItemHeight = 15;
            ListaKlientow.Location = new Point(12, 12);
            ListaKlientow.Name = "ListaKlientow";
            ListaKlientow.Size = new Size(776, 379);
            ListaKlientow.TabIndex = 2;
            ListaKlientow.DoubleClick += ListaKlientow_DoubleClick;
            // 
            // textBoxKlientID
            // 
            textBoxKlientID.Location = new Point(12, 415);
            textBoxKlientID.Name = "textBoxKlientID";
            textBoxKlientID.Size = new Size(100, 23);
            textBoxKlientID.TabIndex = 4;
            // 
            // buttonOznacz
            // 
            buttonOznacz.Location = new Point(713, 414);
            buttonOznacz.Name = "buttonOznacz";
            buttonOznacz.Size = new Size(75, 23);
            buttonOznacz.TabIndex = 5;
            buttonOznacz.Text = "Oznacz";
            buttonOznacz.UseVisualStyleBackColor = true;
            buttonOznacz.Click += buttonOznacz_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 397);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 6;
            label1.Text = "ID Klienta";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(130, 397);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 7;
            label2.Text = "Cena sprzedaży";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(252, 397);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 8;
            label3.Text = "Data";
            // 
            // OznJakoSprzedanyForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonOznacz);
            Controls.Add(textBoxKlientID);
            Controls.Add(ListaKlientow);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBoxCenaSprzedazy);
            Name = "OznJakoSprzedanyForm";
            Text = "OznJakoSprzedany";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxCenaSprzedazy;
        private DateTimePicker dateTimePicker1;
        private ListBox ListaKlientow;
        private TextBox textBoxKlientID;
        private Button buttonOznacz;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}