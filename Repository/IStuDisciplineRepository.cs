using EDUMAN.Models;

namespace EDUMAN.Repository
{
    public interface IStuDisciplineRepository
    {
        List<student_discipline> GetList();
        student_discipline? GetById(int id);

        void Add(student_discipline stuDis);
        void Edit(student_discipline stuDis);
        void Delete(int id);

    }
}
