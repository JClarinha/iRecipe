using iRecipeAPI.Domain;
using iRecipeAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace iRecipeAPI.Controllers
{


    [Route("iRecipeAPI/[Controller]")]
    [ApiController]
    public class IngredientRecipeController : ControllerBase
    {
        private IIngredientRecipeService _ingredientRecipeService;

        public IngredientRecipeController(IIngredientRecipeService ingredientRecipeService)
        {
            _ingredientRecipeService = ingredientRecipeService;
        }

        [HttpGet]
        public List<IngredientRecipe> GetAllIngredientRecipes()
        {
            return _ingredientRecipeService.GetAll();
        }

        [HttpGet("{id}")]
        public List<IngredientRecipe> GetAllByRecipeId(int id)
        {
            return _ingredientRecipeService.GetAllByRecipeId(id);
        }

        [HttpPost]
        public IngredientRecipe SaveIngredientRecipe(IngredientRecipe ingredientRecipe)
        {
            return _ingredientRecipeService.SaveIngredientRecipe(ingredientRecipe);
        }

        [HttpDelete]
        public void DeleteIngredientRecipe(int id)
        {
            _ingredientRecipeService.RemoveIngredientRecipe(id);
        }

    }
}
