using EDUMAN.Data;
using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public class StuRewardRepository : IStuRewardRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StuRewardRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(student_reward studentReward)
        {
            _dbContext.student_rewards.Add(studentReward);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var rs = _dbContext.student_rewards.FirstOrDefault(r => r.id == id);
            if(rs != null)
            {
                _dbContext.student_rewards.Remove(rs);
                _dbContext.SaveChanges();
            }
        }

        public student_reward GetById(int id)
        {
            return _dbContext.student_rewards.Where(r => r.id == id).FirstOrDefault();
        }

        public List<student_reward> GetList()
        {
            return _dbContext.student_rewards.ToList();
        }

        public void Update(student_reward studentReward)
        {
            var rs = _dbContext.student_rewards.FirstOrDefault(r => r.id == studentReward.id);
            if (rs != null)
            {
                _dbContext.student_rewards.Update(rs);
                _dbContext.SaveChanges();
            }
        }
    }
}
