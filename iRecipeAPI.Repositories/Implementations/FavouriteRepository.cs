using iRecipe.Domain;
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
    public class FavouriteRepository : IFavouriteRepository
    {
        private readonly DbSet<Favourite> _dbSet;

        public FavouriteRepository(iRecipeAPIDBContext irecipeAPIDBContext)
        {
            _dbSet = irecipeAPIDBContext.Set<Favourite>();
        }

        public List<Favourite> GetAllByUser(User user)
        {
            return _dbSet.ToList();
        }

        public Favourite Add(Favourite favourite)
        {
            _dbSet.Add(favourite);
            return favourite;
        }

        public void Remove(Favourite favourite)
        {
            _dbSet.Remove(favourite);
        }




    }
}
