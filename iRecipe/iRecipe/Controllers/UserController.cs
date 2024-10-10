using iRecipeAPI.Domain;
using iRecipeAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace iRecipeAPI.Controllers
{


    [Route("iRecipeAPI/[Controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public List<User> GetAllUsers()
        {
            return _userService.GetAll();
        }

        [HttpGet("{id}")]
        public User GetById(int id)
        {
            return _userService.GetById(id);
        }

        [HttpPost]
        public User SaveUser(User user)
        {
            return _userService.SaveUser(user);
        }

        [HttpDelete]
        public void DeleteUser(int id)
        {
            _userService.RemoveUser(id);
        }

    }
}
