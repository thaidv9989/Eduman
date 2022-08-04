using EDUMAN.Models;

namespace EDUMAN.Services
{
    public interface IStuRewardService
    {
        List<student_reward> GetList();
        student_reward GetById(int swid);
        void Add(student_reward studentReward);
        void Update(student_reward studentReward);
        void Delete(int id);
    }
}
