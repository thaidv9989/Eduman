using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUMAN.Controllers
{
    [Route("api/eduTypes")]
    public class EduTypesController : ControllerBase
    {
        private readonly IEduTypeService _educationService;

        public EduTypesController(IEduTypeService educationService)
        {
            _educationService = educationService;
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_educationService.GetOne(id));
        }

        [HttpGet("list")]
        public List<education_type> GetList()
        {
            return _educationService.GetList();
        }
        [HttpPost("create")]
        public IActionResult PostEduType(education_type edu)
        {
            try
            {
                _educationService.Create(edu);
                return Ok(edu);
            }
            catch (Exception)
            {

                return BadRequest(Messages.BAD_REQUEST);
            }
        }
        [HttpPut("edit")]
        public IActionResult PutEduType(education_type edu)
        {
            try
            {
                _educationService.Update(edu);
                return Ok(edu);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        [HttpPut("delete")]
        public IActionResult Delete(int id)
        {
            var check = _educationService.GetOne(id);
            if (check == null)
            {
                return BadRequest(id);
            }
            else
            {
                _educationService.Del(id);
                return Ok(id);
            }
        }
    }
}
