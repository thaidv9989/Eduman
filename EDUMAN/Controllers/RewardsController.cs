using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Services;
using Microsoft.AspNetCore.Mvc;

namespace EDUMAN.Controllers
{
    [Route("api/rewards")]
    public class RewardsController : Controller
    {
        private readonly IRewardService _rewardService;

        public RewardsController(IRewardService rewardService)
        {
            _rewardService = rewardService;
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_rewardService.GetOne(id));
        }

        [HttpGet("list")]
        public List<reward> GetList()
        {
            return _rewardService.GetAll();
        }
        [HttpPost("create")]
        public IActionResult PostReward(reward re)
        {
            try
            {
                _rewardService.Create(re);
                return Ok(Messages.CREATE_REWARS_SUCCESS);
            }
            catch (Exception)
            {

                return BadRequest(Messages.BAD_REQUEST);
            }
        }
        [HttpPut("edit")]
        public IActionResult PutReward(reward re)
        {
            try
            {
                _rewardService.Update(re);  
                return Ok(Messages.UPDATE_REWARS_SUCCESS);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
        [HttpPut("delete")]
        public IActionResult DisReward(int id)
        {
            var check = _rewardService.GetOne(id);
            if (check == null)
            {
                return BadRequest(id);
            }
            else
            {
                _rewardService.Delete(id);
                return Ok(id);
            }
        }


    }
}
