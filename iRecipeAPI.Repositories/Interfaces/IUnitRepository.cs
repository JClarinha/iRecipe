using iRecipe.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iRecipeAPI.Repositories.Interfaces
{
    public interface IUnitRepository
    {
        List<Unit> GetAll();
        Unit GetByName(string name);
        Unit GetById(int id);
        Unit Add(Unit unit);
        Unit Update(Unit unit);
        void Remove(Unit unit);
       

    }
}
