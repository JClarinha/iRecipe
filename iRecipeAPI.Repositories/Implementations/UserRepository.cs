using iRecipe.Domain;
using iRecipeAPI.Data.Context;
using iRecipeAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRecipeAPI.Repositories.Implementations
{
    public  class UserRepository : IUserRepository
    {
        private readonly DbSet<User> _dbSet;
        

        public UserRepository (iRecipeAPIDBContext irecipeAPIDBContext)
        {
            _dbSet = irecipeAPIDBContext.Set<User>();
        }

        public List<User> GetAll()
        {
            return _dbSet.ToList();
        }

        public User GetById(int id) 
        {
            return _dbSet.FirstOrDefault(user => user.Id == id);
        }

        public List <User> GetByEmail(string email) 
        {
            return _dbSet.Where(user => user.Email == email).ToList();
        }

        public User Add(User user) 
        {
            _dbSet.Add(user);
            return user;
        }

        public User Update(User user)
        {
            _dbSet.Update(user);
            return user;
        }

        public void Remove(User user)
        {
            _dbSet.Remove(user) ;
        }

    }
}
