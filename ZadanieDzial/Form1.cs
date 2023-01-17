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
            string[] comboBoxVar = { "IT", "HR", "Design" };
            comboBoxDzial.Items.AddRange(comboBoxVar);

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
            if (comboBoxDzial.SelectedIndex == 0) { selected = 1; };
            if (comboBoxDzial.SelectedIndex == 1) { selected = 2; };
            if (comboBoxDzial.SelectedIndex == 2) { selected = 3; };
            
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
