using System.ComponentModel.DataAnnotations;

namespace ZadanieDzial
{
    public class Dzial
    {
        [Key]
        public int IDDzial { get; set; }
        public string NazwaDzialu { get; set; }

    }
}