using iRecipeAPI.Domain;
using iRecipeAPI.Data.Context;
using iRecipeAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace iRecipeAPI.Repositories.Implementations
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly DbSet<Ingredient> _dbSet;
        
        public IngredientRepository(iRecipeAPIDBContext irecipeAPIDBContext)
        {
            _dbSet = irecipeAPIDBContext.Set<Ingredient>();
        }

        public List<Ingredient> GetAll()
        {
            return _dbSet.ToList();
        }

        public Ingredient GetById(int id)
        {
            return _dbSet.FirstOrDefault(ingredient => ingredient.Id ==id);
        }

        public bool GetAny(int id)
        {
            return _dbSet.Any(ingredient => ingredient.Id == id);
        }

        public List<Ingredient> GetByName(string name)
        {
            return _dbSet.Where(ingredient => ingredient.Name.Contains(name)).ToList();
        }

        public Ingredient Add(Ingredient ingredient)
        {
            _dbSet.Add(ingredient);
            return ingredient;
        }

        public Ingredient Update(Ingredient ingredient) 
        {
            _dbSet.Update(ingredient);
            return ingredient;
        }

        public void Remove(Ingredient ingredient)
        {
            _dbSet.Remove(ingredient);

        }











    }
}
