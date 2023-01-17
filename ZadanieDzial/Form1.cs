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
      
        public Form1()
        {
            InitializeComponent();
            
            
        }
        public void loadingListy()
        {
            using (var db = new obsluga())
            {
                
                var query = from p in db.Pracownicy
                            join d in db.Dzial on p.FK_Dzial equals d.IDDzial
                            select new
                            {
                                p.Imie,
                                p.Nazwisko,
                                d.NazwaDzialu,
                            };


            }
        }
    }
}
