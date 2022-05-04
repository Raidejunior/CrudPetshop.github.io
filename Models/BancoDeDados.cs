using Microsoft.EntityFrameworkCore;

namespace CrudPetshop.Models
{
    public class BancoDeDados : DbContext
    {
        public DbSet<Animal> Animais { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=crudpetshop;Integrated Security=true");
        }
    }
}
