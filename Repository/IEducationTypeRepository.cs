using EDUMAN.Models;

namespace EDUMAN.Repository
{
    public interface IEducationTypeRepository
    {
        List<education_type> GetAll();
        education_type? GetById(int id);
        void Add(education_type edu);
        void Edit(education_type edu);
        void Del(int id);
    }
}
