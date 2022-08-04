using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUMAN.Controllers
{
    [Route("api/stuRelatives")]

    public class StudentRelativesController : ControllerBase
    {
        private readonly IStuRelativeService _stuRelative;

        public StudentRelativesController(IStuRelativeService stuRelative)
        {
            _stuRelative = stuRelative;
        }

        [HttpGet("list")]
        public IActionResult GetList()
        {
            return Ok(_stuRelative.GetList());
        }
        [HttpGet("detail/id")]
        public IActionResult GetById(int id)
        {
            return Ok(_stuRelative.GetOne(id));
        }
        [HttpPost("create")]
        public IActionResult PostNew(student_relative stuRelative)
        {
            try
            {
                _stuRelative.Create(stuRelative);
                return Ok(stuRelative);
            }
            catch (Exception)
            {

                return BadRequest(Messages.BAD_REQUEST);
            }
        }
        [HttpPut("edit/id")]
        public IActionResult Put(student_relative stuRelative)
        {
            try
            {
                _stuRelative.Update(stuRelative);
                return Ok(stuRelative);
            }
            catch (Exception)
            {

                return BadRequest(Messages.BAD_REQUEST);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var check = _stuRelative.GetOne(id);
            if (check == null)
            {
                return BadRequest(id);
            }
            else
            {
                _stuRelative.Delete(id);
                return Ok(id);
            }
        }
    }
}
