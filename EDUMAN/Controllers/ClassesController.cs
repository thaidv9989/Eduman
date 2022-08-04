using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUMAN.Controllers
{
    [Route("api/classes")]
    public class ClassesController : ControllerBase
    {
        private readonly IClassService _classService;

        public ClassesController(IClassService classService)
        {
            _classService = classService;
        }

        [HttpGet("list")]
        public IActionResult GetList()
        {
            return Ok(_classService.GetList());
        }

        [HttpGet("search")]
        public IActionResult SearchParam(int majorId)
        {
            var rs = _classService.Search(majorId);
            if (rs == null)
            {
                return NotFound(Messages.NOTFOUND_REQUEST);
            }
            return Ok(rs);

        }

        [HttpGet("detail/id")]
        public IActionResult Details(string id)
        {
            return Ok(_classService.GetOne(id));
        }

        [HttpPost("create")]
        public IActionResult CreateClass(e_class clas)
        {
            try
            {
                _classService.Create(clas);
                return Ok(Messages.ADD_SUCCESS);
            }
            catch (Exception)
            {

                throw new Exception();
            }
        }

        [HttpPut("edit")]
        public IActionResult UpdateClass(e_class clas)
        {
            try
            {
                _classService.Update(clas);
                return Ok(Messages.EDIT_SUCCESS);
            }
            catch (Exception ex)
            {

                return BadRequest(new {error =ex.Message});
            }
        }

        [HttpPut("disable")]
        public IActionResult Delete(string id)
        {
            _classService.Delete(id);
            return Ok(Messages.DEL_SUCCESS);
        }
    }
}
