using iRecipeAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRecipeAPI.Repositories.Implementations
{
    public class IRecipeRepository : IIRecipeRepository
    {
        private readonly DbSet<iRecipe> _dbSet;
    }
}
