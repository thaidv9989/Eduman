using EDUMAN.Models;
using EDUMAN.Repository.Implements;

namespace EDUMAN.Services.Implements
{
    public class RewardService : IRewardService
    {
        private readonly IRewardRepository _rewardRepository;

        public RewardService(IRewardRepository rewardRepository)
        {
            _rewardRepository = rewardRepository;
        }
        public void Create(reward rew)
        {
            _rewardRepository.Add(rew);
        }

        public void Delete(int id)
        {
            _rewardRepository.Delete(id);
        }

        public List<reward> GetAll()
        {
           return _rewardRepository.GetAll();
        }

        public reward? GetOne(int id)
        {
            return _rewardRepository.GetOne(id);
        }

        public void Update(reward rew)
        {
            _rewardRepository.Update(rew);
        }
    }
}
