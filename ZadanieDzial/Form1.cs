using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieDzial
{
    public partial class Form1 : Form
    {
        int selected;

        public Form1()
        {
            InitializeComponent();
            ComboBoxZapelnienie();

        }

        
        public void ComboBoxZapelnienie() {

            
            using (var db = new obsluga())
            {
                var query = from d in db.Dzial
                            select new
                            {

                                d.NazwaDzialu,
                            };
                foreach (var item in query)
                {
                    comboBoxDzial.Items.Add(item.NazwaDzialu);
                }
            }

        }
        
        public void loadingListy()
        {
            
            using (var db = new obsluga())
            {
                listBoxWynik.Items.Clear();
                var query = from p in db.Pracownicy
                            join d in db.Dzial on p.FK_Dzial equals d.IDDzial
                            select new
                            {
                                p.Imie,
                                p.Nazwisko,
                                d.NazwaDzialu,
                               
                            };
                
                foreach (var item in query)
                {
                    listBoxWynik.Items.Add(item.Imie + " " + item.Nazwisko + ", " + item.NazwaDzialu);
                }


            }
        }

        private void buttonOdswiez_Click(object sender, EventArgs e)
        {
            loadingListy();
        }

        private void comboBoxDzial_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected = comboBoxDzial.SelectedIndex + 1;      
        }

        private void buttonZapisz_Click(object sender, EventArgs e)
        {
            string imieTextBox = textBoxImie.Text;
            string nazwiskoTextBox = textBoxNazwisko.Text;
            
            using (var db = new obsluga())
            {
                Pracownicy pracownik = new Pracownicy
                {
                    Imie = imieTextBox,
                    Nazwisko = nazwiskoTextBox,
                    FK_Dzial = selected,
                };
                db.Pracownicy.Add(pracownik);
                db.SaveChanges();
            }
            loadingListy();
        }
    }
}
