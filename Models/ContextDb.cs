using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkEducation.Models
{
    public class ContextDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-3BJ5GK9;Database=BookStore;Integrated Security=true");
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Education> Educations { get; set; }
    }
}
