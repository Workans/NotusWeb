using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotusWeb.data.Context
{
    public class NotusContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Description> Descriptions { get; set; }
        public DbSet<LanguageCode> LanguagesCode { get; set; }
        public DbSet<Note> Notes { get; set; }

        public NotusContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=WORKSTATION\\SQLEXPRESS;Database=dbNotus;Trusted_Connection=True;");
        }
    }
}
