using iRecipeAPI.Domain;
using iRecipeAPI.Data.Context;
using iRecipeAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace iRecipeAPI.Repositories.Implementations
{
    public class DifficultyRepository : IDifficultyRepository
    {
        private readonly DbSet<Difficulty> _dbSet;

        public DifficultyRepository(iRecipeAPIDBContext irecipeAPIDBContext)
        {
            _dbSet = irecipeAPIDBContext.Set<Difficulty>();
        }
        
        public List<Difficulty> GetAll()
        {
            return _dbSet.ToList();
        }

        public Difficulty GetById(int id)
        {
            return _dbSet.FirstOrDefault(difficulty => difficulty.Id ==id);
        }

        public bool GetAny(int id)
        {
            return _dbSet.Any(difficulty => difficulty.Id == id);
        }

        public List<Difficulty> GetByName(string name)
        {
            return _dbSet.Where(difficulty => difficulty.Name.Contains(name)).ToList();
        }
        
        public Difficulty Add(Difficulty difficulty)
        {
            _dbSet.Add(difficulty);
            return difficulty;
        }

        public Difficulty Update(Difficulty difficulty)
        {
            _dbSet.Update(difficulty);
            return difficulty;
        }

        public void Remove(Difficulty difficulty)
        {
            _dbSet.Remove(difficulty);
        }

    }
}
