﻿using iRecipe.Domain;
using Microsoft.EntityFrameworkCore;



namespace iRecipeAPI.Data.Context
{
    public class iRecipeAPIDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<Recipe> Recepies { get; set; }
        public DbSet<IngredientRecipe> IngredientRecepies { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        //public DbSet<Favourite> Favorits { get; set; }
        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=localhost; database=iRecipe; integrated security=true; TrustServerCertificate=True");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Relacionamento entre Comment e Recipe
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.Recipe)
                .WithMany() // Sem navegação inversa
                .HasForeignKey(c => c.RecipeId)
                .OnDelete(DeleteBehavior.Cascade); // Exclusão em cascata permitida para Recipes

            // Relacionamento entre Comment e User
            modelBuilder.Entity<Comment>()
                .HasOne(c => c.User)
                .WithMany() // Sem navegação inversa
                .HasForeignKey(c => c.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Impede cascata na exclusão de Users

            
            /* Configurando a tabela de junção FavoriteRecipe
            modelBuilder.Entity<Favourite>()
                .HasKey(f => new { f.UserId, f.RecipeId }); // Chave composta*/

            modelBuilder.Entity<Favourite>()
                .HasOne(f => f.User)
                .WithMany() // Sem navegação inversa em User
                .HasForeignKey(f => f.UserId)
                .OnDelete(DeleteBehavior.Restrict); // Cascata na exclusão de usuários

            modelBuilder.Entity<Favourite>()
                .HasOne(f => f.Recipe)
                .WithMany() // Sem navegação inversa em Recipe
                .HasForeignKey(f => f.RecipeId)
                .OnDelete(DeleteBehavior.Cascade); // Cascata na exclusão de receitas
        }

    }






}

