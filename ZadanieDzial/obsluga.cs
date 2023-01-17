using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace ZadanieDzial
{
    public class obsluga : DbContext
    {
        public DbSet<Dzial> Dzial { get; set; }
        public DbSet<Pracownicy> Pracownicy { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source = kotlet_schabowy.db");
            base.OnConfiguring(optionsBuilder);
        }

    }
}
