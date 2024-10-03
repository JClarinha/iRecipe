using iRecipe.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRecipeAPI.Repositories.Interfaces
{
    public interface IFavouriteRepository
    {
        List<Favourite> GetAllByUser(User user);
        Favourite Add(Favourite favourite);
        void Remove(Favourite favourite);
    }
}
