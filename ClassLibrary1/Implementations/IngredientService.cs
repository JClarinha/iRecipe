using iRecipeAPI.Domain;
using iRecipeAPI.Data.Context;
using iRecipeAPI.Repositories.Implementations;
using iRecipeAPI.Repositories.Interfaces;
using iRecipeAPI.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRecipeAPI.Services.Implementations
{
    public class IngredientService : IIngredientService
    {
        private iRecipeAPIDBContext _irecipeAPIDBContext;
        private IIngredientRepository _ingredientRepository;


        public IngredientService(iRecipeAPIDBContext irecipeAPIDBContext, IIngredientRepository ingredientRepository)
        {
            _irecipeAPIDBContext = irecipeAPIDBContext;
            _ingredientRepository = ingredientRepository;
        }


        public List<Ingredient> GetAll()
        {
            return _ingredientRepository.GetAll();
        }

        public Ingredient GetById(int id)
        {
            return _ingredientRepository.GetById(id);
        }

        public Ingredient SaveIngredient(Ingredient ingredient)
        {
            bool ingredientExists = _ingredientRepository.GetAny(ingredient.Id);

            if (!ingredientExists)
            {
                ingredient = _ingredientRepository.Add(ingredient);
            }
            else
            {
                ingredient = _ingredientRepository.Update(ingredient);
            }

            _irecipeAPIDBContext.SaveChanges();
            return ingredient;
        }

        public void RemoveIngredient(int id)
        {
            Ingredient ingredientResult = _ingredientRepository.GetById(id);
            if (ingredientResult != null)
            {
                _ingredientRepository.Remove(ingredientResult);
                _irecipeAPIDBContext.SaveChanges();
            }
        }
    }
}
