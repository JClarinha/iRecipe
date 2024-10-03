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
    public class CommentRepository : ICommentRepository
    {
        private readonly DbSet<Comment> _dbSet;

        public CommentRepository(iRecipeAPIDBContext irecipeAPIDBContext)
        {
            _dbSet = irecipeAPIDBContext.Set<Comment>();
        }

        public List<Comment> GetAll() 
        {
            return _dbSet.ToList();        
        }

        public Comment GetById(int id)
        {
            return _dbSet.FirstOrDefault(comment => comment.Id == id);
        }

        public Comment Add(Comment comment)
        {
            _dbSet.Add(comment);
            return comment;
        }

        public Comment Update(Comment comment)
        {
            _dbSet.Update(comment);
            return comment;
        }

        public void Remove(Comment comment)
        {
            _dbSet.Remove(comment);
        }
    }

}
