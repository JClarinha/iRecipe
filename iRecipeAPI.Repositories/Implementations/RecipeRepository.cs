using iRecipeAPI.Domain;
using iRecipeAPI.Data.Context;
using iRecipeAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace iRecipeAPI.Repositories.Implementations
{
    public class RecipeRepository : IRecipeRepository
    {
        private readonly DbSet<Recipe> _dbSet;


        public RecipeRepository(iRecipeAPIDBContext irecipeAPIDBContext)
        {
            _dbSet = irecipeAPIDBContext.Set<Recipe>();
        }

        public List<Recipe> GetAll()
        {
            return _dbSet.ToList();
        }

        public Recipe GetById(int id)
        {
            return _dbSet.FirstOrDefault(recipe => recipe.Id ==id);
        }

        public bool GetAny(int id)
        {
            return _dbSet.Any(recipe => recipe.Id == id);
        }

        public Recipe GetLast()
        {
            return _dbSet.OrderByDescending(p => p.RecipeDate).FirstOrDefault();
        }

        public List<Recipe> GetByName(string name)
        {
            return _dbSet.Where(recipe => recipe.Name.Contains(name)).ToList();
        }

        public Recipe Add(Recipe recipe)
        {
            _dbSet.Add(recipe);
            return recipe;
        }

        public Recipe Update(Recipe recipe)
        {
            _dbSet.Update(recipe);
            return recipe;
        }

        public void Remove(Recipe recipe)
        {
            _dbSet.Remove(recipe);
        }


    }

}
