using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cold.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cold.DataAccess
{
    public class BookDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=DESKTOP-79VLTFV; Database=ColdDB;uid=sa;pwd=10ed10;");
        }

        public DbSet<Book> Books { get; set; }
    }
}
