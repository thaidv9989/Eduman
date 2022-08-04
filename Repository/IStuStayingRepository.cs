using EDUMAN.Models;

namespace EDUMAN.Repository
{
    public interface IStuStayingRepository
    {
        List<student_staying> GetAll();

        student_staying? GetById(int id);

        void Add(student_staying staying);
        void Update(student_staying staying);
        void Delete(int id);
    }
}
