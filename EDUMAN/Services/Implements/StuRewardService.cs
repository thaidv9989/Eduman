using EDUMAN.Models;
using EDUMAN.Repository;

namespace EDUMAN.Services.Implements
{
    public class StuRewardService : IStuRewardService
    {
        private readonly IStuRewardRepository _stuRewardRepository;

        public StuRewardService(IStuRewardRepository stuRewardRepository)
        {
            _stuRewardRepository = stuRewardRepository;
        }
        public void Add(student_reward studentReward)
        {
            _stuRewardRepository.Add(studentReward);
        }

        public void Delete(int id)
        {
            _stuRewardRepository.Delete(id);
        }

        public student_reward GetById(int swid)
        {
            return _stuRewardRepository.GetById(swid);
        }

        public List<student_reward> GetList()
        {
            return _stuRewardRepository.GetList();
        }

        public void Update(student_reward studentReward)
        {
            _stuRewardRepository.Update(studentReward);
        }
    }
}
