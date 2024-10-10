using iRecipeAPI.Domain;
using iRecipeAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace iRecipeAPI.Controllers
{


    [Route("iRecipeAPI/[Controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public List<Category> GetAllCategories()
        {
            return _categoryService.GetAll();
        }

        [HttpGet("{id}")]
        public Category GetById(int id)
        {
            return _categoryService.GetById(id);
        }

        [HttpPost]
        public Category SaveCategory(Category category)
        {
            return _categoryService.SaveCategory(category);
        }

        [HttpDelete]
        public void DeleteCategory(int id)
        {
            _categoryService.RemoveCategory(id);
        }

    }
}
