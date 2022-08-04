using EDUMAN.Models;

namespace EDUMAN.Services
{
    public interface IEduTypeService
    {
        List<education_type> GetList();
        education_type? GetOne(int id);
        void Create(education_type edu);
        void Update(education_type edu);
        void Del(int id);
    }
}
