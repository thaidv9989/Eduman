using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Services;
using Microsoft.AspNetCore.Mvc;

namespace EDUMAN.Controllers
{
    [Route("api/disciplines")]
    public class DisciplinesController : Controller
    {
        private readonly IDisciplineService _disService;

        public DisciplinesController(IDisciplineService disService)
        {
            _disService = disService;
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_disService.GetOne(id));
        }

        [HttpGet("list")]
        public List<discipline> GetList()
        {
            return _disService.GetAll();
        }
        [HttpPost("create")]
        public IActionResult PostDiscipline(discipline dis)
        {
            try
            {
                _disService.Add(dis);
                return Ok(dis);
            }
            catch (Exception)
            {

                return BadRequest(Messages.BAD_REQUEST);
            }
        }
        [HttpPut("edit")]
        public IActionResult PutDiscipline(discipline dis)
        {
            try
            {
                _disService.Update(dis);
                return Ok(dis);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        [HttpPut("delete")]
        public IActionResult DisDiscipline(int id)
        {
            var check = _disService.GetOne(id);
            if (check == null)
            {
                return BadRequest(id);
            }
            else
            {
                _disService.Delete(id);
                return Ok(id);
            }
        }
    }
}
