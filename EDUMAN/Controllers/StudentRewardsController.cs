using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDUMAN.Controllers
{
    [Route("api/student_rewards")]

    public class StudentRewardsController : ControllerBase
    {
        private readonly IStuRewardService _stuRewardService;

        public StudentRewardsController(IStuRewardService stuRewardService)
        {
            _stuRewardService = stuRewardService;
        }

        [HttpGet("list")]
        public IActionResult GetAll()
        {
            return Ok(_stuRewardService.GetList());
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            return Ok(_stuRewardService.GetList());
        }


        [HttpPost("create")]
        public IActionResult PostNew(student_reward studentReward)
        {
            try
            {
                _stuRewardService.Add(studentReward);
                return Ok(studentReward);
            }
            catch (Exception)
            {

                throw new Exception(Messages.BAD_REQUEST);
            }
        }

        [HttpPut("edit")]
        public IActionResult PutSW(student_reward studentReward)
        {
            try
            {
                _stuRewardService.Update(studentReward);
                return Ok(studentReward);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }


        [HttpDelete("{id}")]
        public IActionResult DelSW(int id)
        {
            _stuRewardService.Delete(id);
            return Ok(Messages.DELETE_SUCCESSFULLY);
        }
    }
}
