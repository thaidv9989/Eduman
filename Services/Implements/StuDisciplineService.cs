using EDUMAN.Models;
using EDUMAN.Repository;

namespace EDUMAN.Services.Implements
{
    public class StuDisciplineService : IStuDisciplineService
    {
        private readonly IStuDisciplineRepository _stuDiscipline;

        public StuDisciplineService(IStuDisciplineRepository stuDiscipline)
        {
            _stuDiscipline = stuDiscipline;
        }
        public void Create(student_discipline stuDis)
        {
            _stuDiscipline.Add(stuDis);
        }

        public void Del(int id)
        {
            _stuDiscipline.Delete(id);
        }

        public List<student_discipline> GetAll()
        {
            return _stuDiscipline.GetList();
        }

        public student_discipline? GetOne(int id)
        {
            return _stuDiscipline.GetById(id);
        }

        public void Update(student_discipline stuDis)
        {
            _stuDiscipline.Edit(stuDis);
        }
    }
}
