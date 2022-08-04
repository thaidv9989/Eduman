using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUMAN.Controllers
{
    [Route("api/schoolyears")]
    public class SchoolYearsController : ControllerBase
    {
        private readonly ISchoolYearService _schoolYearService;

        public SchoolYearsController(ISchoolYearService schoolYearService)
        {
            _schoolYearService = schoolYearService;
        }

        [HttpGet("list")]
        public IActionResult GetAllSchoolYear()
        {
            return Ok(_schoolYearService.GetList());

        }

        [HttpGet("search")]
        public IActionResult SearchParam(int educationTypeId)
        {
            var rs = _schoolYearService.Search(educationTypeId);
            if(rs == null)
            {
                return NotFound(Messages.NOTFOUND_REQUEST);
            }
            return Ok(rs);

        }
        [HttpGet("detail/id")]
        public IActionResult Detail(int id)
        {
            return Ok(_schoolYearService.GetOne(id));

        }
        [HttpPost("create")]
        public IActionResult Create(school_year schoolY)
        {
            try
            {
                _schoolYearService.Add(schoolY);
                return Ok(Messages.ADD_SUCCESS);
            }
            catch (Exception)
            {

                throw new Exception();
            }

        }
        [HttpPut("edit")]
        public IActionResult Edit(school_year schoolY)
        {
            try
            {
                _schoolYearService.Update(schoolY);
                return Ok(Messages.EDIT_SUCCESS);
            }
            catch (Exception)
            {

                throw new Exception("Something went wrong!!!");
            }

        }
        [HttpPut("disable")]
        public IActionResult Delete(int id)
        {
            _schoolYearService.Delete(id);
            return Ok(Messages.DEL_SUCCESS);
        }
    }
}
