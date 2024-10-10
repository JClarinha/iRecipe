using iRecipeAPI.Domain;
using iRecipeAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace iRecipeAPI.Controllers
{


    [Route("iRecipeAPI/[Controller]")]
    [ApiController]
    public class IngredientController : ControllerBase
    {
        private IIngredientService _ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            _ingredientService = ingredientService;
        }

        [HttpGet]
        public List<Ingredient> GetAllIngredients()
        {
            return _ingredientService.GetAll();
        }

        [HttpGet("{id}")]
        public Ingredient GetById(int id)
        {
            return _ingredientService.GetById(id);
        }

        [HttpPost]
        public Ingredient SaveIngredient(Ingredient ingredient)
        {
            return _ingredientService.SaveIngredient(ingredient);
        }

        [HttpDelete]
        public void DeleteIngredient(int id)
        {
            _ingredientService.RemoveIngredient(id);
        }

    }
}
