using System.ComponentModel.DataAnnotations;

namespace ZadanieDzial
{
    public class Pracownicy
    {
        [Key]
        public int IDPracownicy { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int FK_Dzial { get; set; }

    }
}