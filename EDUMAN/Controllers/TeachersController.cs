using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUMAN.Controllers
{
    [Route("api/teachers")]
    public class TeachersController : ControllerBase
    {
        private readonly ITeacherService _teacherService;

        public TeachersController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet("list")]
        public IActionResult GetTeachers()
        {
            return Ok(_teacherService.GetAllTeachers());
        }

        [HttpGet("detail/id")]
        public IActionResult GetTeache(string id)
        {
            return Ok(_teacherService.GetTeacher(id));
        }

        [HttpPost("create")]
        public IActionResult CreateNewTeacher(teacher tc)
        {
            try
            {
                _teacherService.CreateTeacher(tc);
                return Ok(Messages.ADD_SUCCESS);
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }


        [HttpPut("edit")]
        public IActionResult EditTeacher(teacher tc)
        {
            try
            {
                _teacherService.Update(tc);
                return Ok(Messages.EDIT_SUCCESS);
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        [HttpPut("disable")]
        public IActionResult Delele(string id)
        {
            _teacherService.Del(id);
            return Ok(Messages.DEL_SUCCESS);
        }
    }
}
