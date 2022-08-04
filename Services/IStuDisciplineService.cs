using EDUMAN.Models;

namespace EDUMAN.Services
{
    public interface IStuDisciplineService
    {
        List<student_discipline> GetAll();
        student_discipline? GetOne(int id);
        void Create(student_discipline stuDis);
        void Update(student_discipline stuDis);
        void Del(int id);
    }
}
