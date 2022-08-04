using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUMAN.Controllers
{
    [Route("api/majors")]
    public class MajorsController : ControllerBase
    {
        private readonly IMajorService _majorService;

        public MajorsController(IMajorService majorService)
        {
            _majorService = majorService;
        }

        [HttpGet("list")]
        public IActionResult GetList()
        {
            return Ok(_majorService.GetList());
        }

        [HttpGet("search")]
        public IActionResult SearchParam(int schoolYearId)
        {
            var rs = _majorService.Search(schoolYearId);
            if (rs == null)
            {
                return NotFound(Messages.NOTFOUND_REQUEST);
            }
            return Ok(rs);

        }

        [HttpGet("detail/id")]
        public IActionResult Detail(int id)
        {
            return Ok(_majorService.GetDetail(id));
        }

        [HttpPost("create")]
        public IActionResult Create(major maj)
        {
            try
            {
                _majorService.Create(maj);
                return Ok(Messages.ADD_SUCCESS);
            }
            catch (Exception)
            {

                throw new Exception("Something went wrong!!!");
            }
        }

        [HttpPut("edit")]
        public IActionResult Edit(major maj)
        {
            try
            {
                _majorService.Edit(maj);
                return Ok(Messages.EDIT_SUCCESS);
            }
            catch (Exception ex)
            {

                return BadRequest(new {error = ex.Message});
            }
        }

        [HttpPut("disable")]
        public IActionResult Del(int id)
        {
            _majorService.Del(id);
            return Ok(Messages.DEL_SUCCESS);
        }
    }
}
