namespace ZadanieDzial
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxImie = new System.Windows.Forms.TextBox();
            this.textBoxNazwisko = new System.Windows.Forms.TextBox();
            this.comboBoxDzial = new System.Windows.Forms.ComboBox();
            this.buttonZapisz = new System.Windows.Forms.Button();
            this.buttonOdswiez = new System.Windows.Forms.Button();
            this.listBoxWynik = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxImie
            // 
            this.textBoxImie.Location = new System.Drawing.Point(12, 12);
            this.textBoxImie.Name = "textBoxImie";
            this.textBoxImie.Size = new System.Drawing.Size(130, 20);
            this.textBoxImie.TabIndex = 0;
            // 
            // textBoxNazwisko
            // 
            this.textBoxNazwisko.Location = new System.Drawing.Point(12, 38);
            this.textBoxNazwisko.Name = "textBoxNazwisko";
            this.textBoxNazwisko.Size = new System.Drawing.Size(130, 20);
            this.textBoxNazwisko.TabIndex = 1;
            // 
            // comboBoxDzial
            // 
            this.comboBoxDzial.FormattingEnabled = true;
            this.comboBoxDzial.Location = new System.Drawing.Point(12, 64);
            this.comboBoxDzial.Name = "comboBoxDzial";
            this.comboBoxDzial.Size = new System.Drawing.Size(130, 21);
            this.comboBoxDzial.TabIndex = 2;
            this.comboBoxDzial.SelectedIndexChanged += new System.EventHandler(this.comboBoxDzial_SelectedIndexChanged);
            // 
            // buttonZapisz
            // 
            this.buttonZapisz.Location = new System.Drawing.Point(12, 91);
            this.buttonZapisz.Name = "buttonZapisz";
            this.buttonZapisz.Size = new System.Drawing.Size(130, 23);
            this.buttonZapisz.TabIndex = 3;
            this.buttonZapisz.Text = "Zapisz";
            this.buttonZapisz.UseVisualStyleBackColor = true;
            this.buttonZapisz.Click += new System.EventHandler(this.buttonZapisz_Click);
            // 
            // buttonOdswiez
            // 
            this.buttonOdswiez.Location = new System.Drawing.Point(12, 120);
            this.buttonOdswiez.Name = "buttonOdswiez";
            this.buttonOdswiez.Size = new System.Drawing.Size(130, 23);
            this.buttonOdswiez.TabIndex = 4;
            this.buttonOdswiez.Text = "Odśwież";
            this.buttonOdswiez.UseVisualStyleBackColor = true;
            this.buttonOdswiez.Click += new System.EventHandler(this.buttonOdswiez_Click);
            // 
            // listBoxWynik
            // 
            this.listBoxWynik.FormattingEnabled = true;
            this.listBoxWynik.Location = new System.Drawing.Point(148, 12);
            this.listBoxWynik.Name = "listBoxWynik";
            this.listBoxWynik.Size = new System.Drawing.Size(240, 134);
            this.listBoxWynik.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxWynik);
            this.Controls.Add(this.buttonOdswiez);
            this.Controls.Add(this.buttonZapisz);
            this.Controls.Add(this.comboBoxDzial);
            this.Controls.Add(this.textBoxNazwisko);
            this.Controls.Add(this.textBoxImie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxImie;
        private System.Windows.Forms.TextBox textBoxNazwisko;
        private System.Windows.Forms.ComboBox comboBoxDzial;
        private System.Windows.Forms.Button buttonZapisz;
        private System.Windows.Forms.Button buttonOdswiez;
        private System.Windows.Forms.ListBox listBoxWynik;
    }
}

