using iRecipeAPI.Domain;
using iRecipeAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace iRecipeAPI.Controllers
{


    [Route("iRecipeAPI/[Controller]")]
    [ApiController]
    public class DifficultyController : ControllerBase
    {
        private IDifficultyService _difficultyService;

        public DifficultyController(IDifficultyService difficultyService)
        {
            _difficultyService = difficultyService;
        }

        [HttpGet]
        public List<Difficulty> GetAllDifficulties()
        {
            return _difficultyService.GetAll();
        }

        [HttpGet("{id}")]
        public Difficulty GetById(int id)
        {
            return _difficultyService.GetById(id);
        }

        [HttpPost]
        public Difficulty SaveDifficulty(Difficulty difficulty)
        {
            return _difficultyService.SaveDifficulty(difficulty);
        }

        [HttpDelete]
        public void DeleteDifficulty(int id)
        {
            _difficultyService.RemoveDifficulty(id);
        }

    }
}
