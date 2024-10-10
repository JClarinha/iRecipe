using iRecipeAPI.Data.Context;
using iRecipeAPI.Domain;
using iRecipeAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace iRecipeAPI.Controllers
{


    [Route("iRecipeAPI/[Controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        private IRecipeService _recipeService;
        private readonly iRecipeAPIDBContext _dbContext;
        private readonly IWebHostEnvironment _environment;

        public RecipeController(IRecipeService recipeService, iRecipeAPIDBContext dbContext, IWebHostEnvironment environment)
        {
            _recipeService = recipeService;
            _dbContext = dbContext;
            _environment = environment;
        }

        [HttpGet]
        public List<Recipe> GetAllRecipes()
        {
            return _recipeService.GetAll();
        }

        [HttpGet("{id}")]
        public Recipe GetById(int id)
        {
            return _recipeService.GetById(id);
        }

        /* [HttpPost]
         public async Task<IActionResult> SaveRecipe([FromForm] Recipe recipe)
         {
             // Verificar se a imagem foi fornecida
             if (recipe.Image != null)
             {
                 // Definir o caminho para armazenar a imagem
                 var fileName = Path.GetFileNameWithoutExtension(recipe.Image.FileName);
                 var extension = Path.GetExtension(recipe.Image.FileName);
                 var filePath = Path.Combine(_environment.WebRootPath, "images", $"{fileName}_{DateTime.Now.Ticks}{extension}");

                 // Criar a pasta "images" se não existir
                 Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                 // Guardar a imagem no servidor
                 using (var stream = new FileStream(filePath, FileMode.Create))
                 {
                     await recipe.Image.CopyToAsync(stream);
                 }

                 // Guardar o caminho da imagem na entidade
                 recipe.ImagePath = filePath;
             }

             // Adicionar a receita à base de dados
             _dbContext.Recepies.Add(recipe);
             await _dbContext.SaveChangesAsync();

             // Retornar uma resposta bem-sucedida
             return Ok(new { message = "Receita adicionada com sucesso", data = recipe });
         }*/


        [HttpPost] // EUREKA
        public IActionResult SaveRecipe([FromForm] Recipe recipe)
        {
            // Verificar se a imagem foi fornecida
            if (recipe.Image != null)
            {
                // Definir o caminho para armazenar a imagem
                var fileName = Path.GetFileNameWithoutExtension(recipe.Image.FileName);
                var extension = Path.GetExtension(recipe.Image.FileName);
                var filePath = Path.Combine(_environment.WebRootPath, "images", $"{fileName}_{DateTime.Now.Ticks}{extension}");

                // Criar a pasta "images" se não existir
                Directory.CreateDirectory(Path.GetDirectoryName(filePath));

                // Guardar a imagem no servidor de forma síncrona
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    recipe.Image.CopyTo(stream);
                }

                // Guardar o caminho da imagem na entidade
                recipe.ImagePath = filePath;
            }

            // Adicionar a receita à base de dados de forma síncrona
            _dbContext.Recepies.Add(recipe);
            _dbContext.SaveChanges();

            // Retornar uma resposta bem-sucedida
            return Ok(new { message = "Receita adicionada com sucesso", data = recipe });
        }






        [HttpDelete]
        public void DeleteRecipe(int id)
        {
            _recipeService.RemoveRecipe(id);
        }

    }
}
