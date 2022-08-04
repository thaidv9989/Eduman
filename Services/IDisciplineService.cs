using EDUMAN.Models;

namespace EDUMAN.Services
{
    public interface IDisciplineService
    {
        List<discipline> GetAll();
        discipline? GetOne(int id);
        void Add(discipline discip);
        void Update(discipline discip);
        void Delete(int id);
    }
}
