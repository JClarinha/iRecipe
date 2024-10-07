using iRecipeAPI.Data.Context;
using iRecipeAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using iRecipe.Domain;

namespace iRecipeAPI.Repositories.Implementations
{
    public  class IngredientRecipeRepository : IIngredientRecipeRepositoy
    {
        private readonly DbSet<IngredientRecipe> _dbSet;
        private readonly iRecipeAPIDBContext _irecipeAPIDBContext;

        public IngredientRecipeRepository(iRecipeAPIDBContext irecipeAPIDBContext)
        {
            _dbSet = irecipeAPIDBContext.Set<IngredientRecipe>();
            _irecipeAPIDBContext = irecipeAPIDBContext;
        }

        public List<IngredientRecipe> GetAll()
        {
            return _dbSet.ToList();
        }

        public List<IngredientRecipe> GetAllByRecipeId(int recipeId)
        {
            return _dbSet.Where(p => p.RecipeId == recipeId).Include(p => p.Ingredient).ToList();
        }

        public IngredientRecipe GetById(int id)
        {
            return _dbSet
                .Where(p => p.Id == id)
                .Include(p => p.Recipe)
                .ThenInclude(p => p.User)
                .Include(p => p.Ingredient)
                .ThenInclude(p => p.Unit)
                .FirstOrDefault();
        }



    }
}
