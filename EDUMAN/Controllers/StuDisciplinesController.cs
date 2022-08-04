using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUMAN.Controllers
{
    [Route("api/studentDisciplines")]
    public class StuDisciplinesController : ControllerBase
    {
        private readonly IStuDisciplineService _stuDisciplineService;

        public StuDisciplinesController(IStuDisciplineService stuDisciplineService)
        {
            _stuDisciplineService = stuDisciplineService;
        }

        [HttpGet("list")]
        public IActionResult GetAllList()
        {
            return Ok(_stuDisciplineService.GetAll());
        }


        [HttpGet("id")]
        public IActionResult GetByStuDisId(int id)
        {
            return Ok(_stuDisciplineService.GetOne(id));
        }

        [HttpPost("create")]
        public IActionResult Create(student_discipline stuDis)
        {
            try
            {
                _stuDisciplineService.Create(stuDis);
                return Ok(Messages.ADD_SUCCESS);
            }
            catch (Exception)
            {

                throw new Exception("Something went wrong!!!");
            }
        }

        [HttpPut("edit")]
        public IActionResult Edit(student_discipline stuDis)
        {
            try
            {
                _stuDisciplineService.Update(stuDis);
                return Ok(Messages.EDIT_SUCCESS);
            }
            catch (Exception ex)
            {

                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpDelete]
        public IActionResult Del(int id)
        {
            _stuDisciplineService.Del(id);
            return Ok(Messages.DEL_SUCCESS);
        }
    }
}
