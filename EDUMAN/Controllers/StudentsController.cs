using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EDUMAN.Data;
using EDUMAN.Models;
using EDUMAN.Services;
using EDUMAN.Constants;
using Newtonsoft.Json;

namespace EDUMAN.Controllers
{
    [Route("api/students")]
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;
        [Obsolete]
        private readonly IWebHostEnvironment _enviroment;

        [Obsolete]
        public StudentsController(IStudentService studentService, IWebHostEnvironment environment)
        {
            _studentService = studentService;
            _enviroment = environment;
        }

        // GET: Students
        [HttpGet("studentPage")]
        public IActionResult GetAllStudents([FromQuery] PageAction pageAction)
        {

            return Ok(_studentService.GetAll(pageAction));
        }
        [HttpGet("list")]
        public List<student> GetListsStudent()
        {
            return _studentService.GetAllUsers();
        }

        [HttpGet("search")]
        public IActionResult Searchs(string classId, string name, bool gender, string country, string phone, string status)
        {
            
                var rs =  _studentService.Search(classId, name, gender, country, phone, status);
                if (rs == null)
                {
                    return NotFound(Messages.NOTFOUND_REQUEST);
                }
                return Ok(rs);
            
        }



        [HttpGet("getstudent/stuId")]
        public IActionResult GetStudent(string id)
        {
            return Ok(_studentService.GetStudent(id));
        }

        [HttpGet("detail/studentId")]
        public IEnumerable<studentDetails> GetDetailStuInfo(string id)
        {
            var rs = _studentService.ListDetails(id);
            if (rs != null)
            {
                return rs;
            }
            return null;
        }

        [HttpPut("edit")]
        public IActionResult UpdateInfoUser(student stu, IFormFile? image)
        {
            try
            {
                var pathImg = Path.Combine(_enviroment.WebRootPath, "Images", image.FileName);
                var steamImage = new FileStream(pathImg, FileMode.Append);
                image.CopyTo(steamImage);
                var newstu = new student
                {
                    student_id = stu.student_id,
                    img = pathImg,
                    fullname = stu.fullname,
                    gender = stu.gender,
                    country = stu.country,
                    date_of_birth = stu.date_of_birth,
                    place_of_birth = stu.place_of_birth,
                    domicile = stu.domicile,
                    household = stu.household,
                    ethnicity = stu.ethnicity,
                    religion = stu.religion,
                    recruitment_area = stu.recruitment_area,
                    subject = stu.subject,
                    morality = stu.morality,
                    education_level = stu.education_level,
                    policy_type = stu.policy_type,
                    family_category = stu.family_category,
                    communist_youth_day = stu.communist_youth_day,
                    communist_party_day = stu.communist_party_day,
                    identity_number = stu.identity_number,
                    identity_date = stu.identity_date,
                    identity_place = stu.identity_place,
                    bank_account = stu.bank_account,
                    email = stu.email,
                    contact_address = stu.contact_address,
                    phone = stu.phone,
                    class_id = stu.class_id,
                    description = stu.description,
                    state = stu.state,
                    status = stu.status,
                    created_on = stu.created_on,
                    created_by = stu.created_by,
                    updated_on = stu.updated_on,
                    updated_by = stu.updated_by

                };
                _studentService.Update(newstu);
                return Ok(Messages.UPDATE_USER_SUCCESS);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [HttpPost("create")]
        public void CreateNewUser([FromForm] student stu, IFormFile image)
        {
            var pathImg = Path.Combine(_enviroment.WebRootPath, "Images", image.FileName);
            var steamImage = new FileStream(pathImg, FileMode.Append);
            image.CopyTo(steamImage);
            var newstu = new student
            {
                student_id = stu.student_id,
                img = pathImg,
                fullname = stu.fullname,
                gender = stu.gender,
                country = stu.country,
                date_of_birth = stu.date_of_birth,
                place_of_birth = stu.place_of_birth,
                domicile = stu.domicile,
                household = stu.household,
                ethnicity = stu.ethnicity,
                religion = stu.religion,
                recruitment_area = stu.recruitment_area,
                subject = stu.subject,
                morality = stu.morality,
                education_level = stu.education_level,
                policy_type = stu.policy_type,
                family_category = stu.family_category,
                communist_youth_day = stu.communist_youth_day,
                communist_party_day = stu.communist_party_day,
                identity_number = stu.identity_number,
                identity_date = stu.identity_date,
                identity_place = stu.identity_place,
                bank_account = stu.bank_account,
                email = stu.email,
                contact_address = stu.contact_address,
                phone = stu.phone,
                class_id = stu.class_id,
                description = stu.description,
                state = stu.state,
                status = stu.status,
                created_on = stu.created_on,
                created_by = stu.created_by,
                updated_on = stu.updated_on,
                updated_by = stu.updated_by

            };
            _studentService.Create(newstu);
            
        }
        

        /*[HttpPut("disable")]*/
        [HttpDelete]
        public IActionResult DisableUser(string id)
        {
            var check = _studentService.GetStudent(id);
            if (check == null)
            {
                return BadRequest(id);
            }
            else
            {
               _studentService.DisableUser(id);
                return Ok(Messages.DELETE_SUCCESS);
            }
        }
    }
}
