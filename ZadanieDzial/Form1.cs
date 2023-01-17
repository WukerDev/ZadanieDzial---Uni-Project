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
            string[] comboBoxVar = { "IT", "HR", "Design" }; //dodajemy nową tablicę przechowującą stringi o naziwe combo box var
            comboBoxDzial.Items.AddRange(comboBoxVar);  //dodaje wybory wg ilości elementów w tabeli string

        }
        public void loadingListy()  //ładuje listę
        {
            
            using (var db = new obsluga())  //używamy obsluga.cs, potrzebne by program wiedział ze chodzi nam o tabele w bazie danych
            {
                listBoxWynik.Items.Clear();  //czyścimy wświetlane dotychczasowo przedmioty
                var query = from p in db.Pracownicy  //przypisujemy wartości z db.Pracownicy do p
                            join d in db.Dzial on p.FK_Dzial equals d.IDDzial  //przypisujemy db.dzial do d i ustawiamy wartość klucza obcego w tabeli pracownicy równą do IDdzial
                            select new
                            {
                                p.Imie,  //tabela pracownicy, rekord Imie
                                p.Nazwisko,  // tabela pracownicy, rekord Nazwisko
                                d.NazwaDzialu,  //tabela Dział, rekord NazwaDzialu
                               
                            };
                
                foreach (var item in query)  //za każdy przedmiot w query wykonujemy tą pętle
                {
                    listBoxWynik.Items.Add(item.Imie + " " + item.Nazwisko + ", " + item.NazwaDzialu);  //Dodajemy wartości do listBoxWynik, poprzedzamy nazwę kolumny w tabeli Item. by zakomunikować że to przedmiot
                }


            }
        }

        private void buttonOdswiez_Click(object sender, EventArgs e) //odświeżamy
        {
            loadingListy();  //wywołujemy funkcję odświeżającą
        }

        private void comboBoxDzial_SelectedIndexChanged(object sender, EventArgs e)  //ustalamy co czemu odpowiada
        {
            if (comboBoxDzial.SelectedIndex == 0) { selected = 1; };  //po lewej mamy jaki input może dać użytkownik, od 0 do 3, po prawej zaś konwerujemy to na output jaki idzie do bazy danych.
            if (comboBoxDzial.SelectedIndex == 1) { selected = 2; };  //// Zmieniamy wartość o 1 w górę ponieważ bazy danych liczą od 1 a programy od 0
            if (comboBoxDzial.SelectedIndex == 2) { selected = 3; };  //można to odpowiednio powiększać i zmniejszać w zależności od potrzeby
            
        }

        private void buttonZapisz_Click(object sender, EventArgs e)  //zapisywanie danych
        {
            string imieTextBox = textBoxImie.Text;  // przypisujemy do zmiennej imieTextBox wartość z textboxa
            string nazwiskoTextBox = textBoxNazwisko.Text; //jw
            
            using (var db = new obsluga())
            {
                Pracownicy pracownik = new Pracownicy //tworzymy nowy rekord w tabeli odwołując się do klasy pracownmicy
                {
                    Imie = imieTextBox,  //ustalamy że imie to wartość zmiennej imieTextBox
                    Nazwisko = nazwiskoTextBox,
                    FK_Dzial = selected, //wybór wg combo boxa
                };
                db.Pracownicy.Add(pracownik);  //wysyłamy wartości z powyższych działań do bazyt danych dodając argument nowego pracownika do metody add
                db.SaveChanges();  // zapisujemy zmiany
            }
            loadingListy();  //przeładowujemy listę
        }
    }
}
