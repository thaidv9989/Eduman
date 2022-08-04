using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public interface IRewardRepository
    {
        List<reward> GetAll();
        reward? GetOne(int id);
        void Add(reward rew);
        void Update(reward rew);
        void Delete(int id);

    }
}
