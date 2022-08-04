using EDUMAN.Data;
using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public class RewardRepository : IRewardRepository
    {
        private readonly ApplicationDbContext _context;

        public RewardRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(reward rew)
        {
            bool rs = _context.rewards.Any(x => x.reward_name == rew.reward_name);
            if (rs == true)
            {
                throw new Exception("Something went wrong !!!!");
            }
            _context.rewards.Add(rew);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var rs = _context.rewards.FirstOrDefault(x => x.reward_id == id);
            if(rs != null)
            {
                rs.status = "Deleted";
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Not found");
            }
        }

        public List<reward> GetAll()
        {
            return _context.rewards.ToList();
        }

        public reward? GetOne(int id)
        {
            return _context.rewards.FirstOrDefault(x => x.reward_id == id);
        }

        public void Update(reward rew)
        {
            var rs = _context.rewards.Where(x => x.reward_id == rew.reward_id);
            try
            {
                if (rs != null)
                {
                    _context.rewards.Update(rew);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw new Exception("Invalid");
            }
        }
    }
}
