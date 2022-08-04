using EDUMAN.Models;

namespace EDUMAN.Services
{
    public interface IStuStayingService
    {
        List<student_staying> GetList();

        student_staying? GetOne(int id);

        void Create(student_staying staying);
        void Edit(student_staying staying);
        void Del(int id);
    }
}
