using EDUMAN.Models;

namespace EDUMAN.Repository
{
    public interface ITeacherRepository
    {
        List<teacher> GetAll();
        teacher? GetByTeacherId(string id);
        void Add(teacher tc);
        void Edit(teacher tc);
        void Del(string id);
    }
}
