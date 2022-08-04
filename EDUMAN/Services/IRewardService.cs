using EDUMAN.Models;

namespace EDUMAN.Services
{
    public interface IRewardService
    {
        List<reward> GetAll();
        reward? GetOne(int id);
        void Create(reward rew);
        void Update(reward rew);
        void Delete(int id);
    }
}
