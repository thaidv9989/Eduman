using EDUMAN.Models;

namespace EDUMAN.Repository
{
    public interface IStuRelativeRepository
    {
        List<student_relative> GetAll();

        student_relative? GetById(int id);
        void Add(student_relative stuRelative);
        void Edit(student_relative stuRelative);
        void Del(int id);
    }
}
