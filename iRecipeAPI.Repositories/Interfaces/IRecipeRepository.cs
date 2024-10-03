using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iRecipe.Domain;


namespace iRecipeAPI.Repositories.Interfaces
{
    public  interface IIRecipeRepository
    {
        List<Recipe> GetAll();
        Recipe GetById(int id);
        List<Recipe> GetByName(string name);
        Recipe Add(Recipe recipe);
        Recipe Update(Recipe recipe);
        void Remove(Recipe recipe);


    }
}
