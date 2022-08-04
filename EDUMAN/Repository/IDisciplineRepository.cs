using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public interface IDisciplineRepository
    {
        List<discipline> GetAll();
        discipline? GetOne(int id);
        void Add(discipline disc);
        void Update(discipline disc);
        void Delete(int id);

    }
}
