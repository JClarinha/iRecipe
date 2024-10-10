using iRecipeAPI.Domain;
using iRecipeAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace iRecipeAPI.Controllers
{


    [Route("iRecipeAPI/[Controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public List<Comment> GetAllComments()
        {
            return _commentService.GetAll();
        }

        [HttpGet("{id}")]
        public Comment GetById(int id)
        {
            return _commentService.GetById(id);
        }

        [HttpPost]
        public Comment SaveComment(Comment comment)
        {
            return _commentService.SaveComment(comment);
        }

        [HttpDelete]
        public void DeleteComment(int id)
        {
            _commentService.RemoveComment(id);
        }

    }
}
