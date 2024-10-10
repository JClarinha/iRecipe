using iRecipeAPI.Domain;
using iRecipeAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace iRecipeAPI.Controllers
{


    [Route("iRecipeAPI/[Controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private IUnitService _unitService;

        public UnitController(IUnitService unitService)
        {
            _unitService = unitService;
        }

        [HttpGet]
        public List<Unit> GetAllUnits()
        {
            return _unitService.GetAll();
        }

        [HttpGet("{id}")]
        public Unit GetById(int id)
        {
            return _unitService.GetById(id);
        }

        [HttpPost]
        public Unit SaveUnit(Unit unit)
        {
            return _unitService.SaveUnit(unit);
        }

        [HttpDelete]
        public void DeleteUnit(int id)
        {
            _unitService.RemoveUnit(id);
        }

    }
}
