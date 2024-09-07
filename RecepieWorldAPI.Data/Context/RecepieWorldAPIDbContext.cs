using Microsoft.EntityFrameworkCore;

namespace RecepieWorldAPI.Data.Context
{
    public class RecepieWorldAPIDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Recipe> Recepies { get; set; }
        public DbSet<IngredientRecepie> IngredientRecepies { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Favourite> Favorits { get; set; }
        public DbSet<Difficulty> Dificulties { get; set; }
        public DbSet<Coment> Coments { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost; database=RecepieWorldDB; integrated security=true; TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Coment>().Property(p => p.Description).HasMaxLength(500);
        }

    }
}
