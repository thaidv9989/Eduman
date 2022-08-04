using EDUMAN.Models;

namespace EDUMAN.Services
{
    public interface ITeacherService
    {
        List<teacher> GetAllTeachers();

        teacher? GetTeacher(string id);
        void CreateTeacher(teacher tc);
        void Update(teacher tc);
        void Del(string id);
    }
}
