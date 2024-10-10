using iRecipeAPI.Domain;
using iRecipeAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace iRecipeAPI.Controllers
{


    [Route("iRecipeAPI/[Controller]")]
    [ApiController]
    public class FavouriteController : ControllerBase
    {
        private IFavouriteService _favouriteService;

        public FavouriteController(IFavouriteService favouriteService)
        {
            _favouriteService = favouriteService;
        }

        [HttpGet]
        public List<Favourite> GetAllFavourites()
        {
            return _favouriteService.GetAll();
        }

        [HttpGet("{id}")]
        public Favourite GetById(int id)
        {
            return _favouriteService.GetById(id);
        }

        [HttpPost]
        public Favourite SaveFavourite(Favourite favourite)
        {
            return _favouriteService.SaveFavourite(favourite);
        }

        [HttpDelete]
        public void DeleteFavourite(int id)
        {
            _favouriteService.RemoveFavourite(id);
        }

    }
}
