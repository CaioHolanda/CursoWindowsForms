using Microsoft.EntityFrameworkCore;
using System;


namespace CursoWindowsFormsBiblioteca.Classes
{
    public class ByteBankContext : DbContext
    {
        public DbSet<Cliente> TB_Cliente { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=CAIOLAPTOP;Initial Catalog=ByteBank;Persist Security Info=True;User ID=sa;Password=123;Encrypt=False");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteConfiguration());
        }
    }
}