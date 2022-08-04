using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUMAN.Controllers
{
    [Route("api/studyings")]
    
    public class StuStayingsController : ControllerBase
    {
        private readonly IStuStayingService _stuStayingService;

        public StuStayingsController(IStuStayingService stuStayingService)
        {
            _stuStayingService = stuStayingService;
        }

        [HttpGet("list")]
        public List<student_staying> GetList()
        {
            return _stuStayingService.GetList();
        }

        [HttpGet("id")]
        public IActionResult GetById(int id)
        {
            return Ok(_stuStayingService.GetOne(id));
        }

        [HttpPost("create")]
        public IActionResult Post(student_staying staying)
        {
            try
            {
                _stuStayingService.Create(staying);
                return Ok(Messages.ADD_SUCCESS);
            }
            catch (Exception ex)
            {

                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPut("edit")]
        public IActionResult Edit(student_staying staying)
        {
            try
            {
                _stuStayingService.Edit(staying);
                return Ok(Messages.EDIT_SUCCESS);

            }
            catch (Exception)
            {

                throw new Exception("Something went wrong!!!");
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _stuStayingService.Del(id);
            return Ok(Messages.DELETE_SUCCESS);
        }
    }
}
