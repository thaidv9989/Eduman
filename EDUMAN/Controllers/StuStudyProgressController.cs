using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUMAN.Controllers
{
    [Route("api/stuprogress")]
    
    public class StuStudyProgressController : ControllerBase
    {
        private readonly IStudyProgressService _studyProgressService;

        public StuStudyProgressController(IStudyProgressService studyProgressService)
        {
            _studyProgressService = studyProgressService;
        }
        [HttpGet("list")]
        public IActionResult GetList()
        {
            return Ok(_studyProgressService.GetList());
        }

        [HttpGet("detail/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_studyProgressService.GetOne(id));
        }

        [HttpPost("create")]
        public IActionResult PostProgress(student_study_progress progress)
        {
            _studyProgressService.Add(progress);
            return Ok(Messages.ADD_SUCCESS);
        }

        [HttpPut("edit")]
        public IActionResult PutProgress(student_study_progress process)
        {
            try
            {
                _studyProgressService.Edit(process);
                return Ok(Messages.EDIT_SUCCESS);
            }
            catch (Exception ex)
            {

                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpDelete]
        public IActionResult Delele(int id)
        {
            try
            {
                _studyProgressService.Del(id);
                return Ok(Messages.DELETE_SUCCESS);
            }
            catch (Exception ex)
            {

                return BadRequest(new { error = ex.Message });
            }
        }
    }
}
