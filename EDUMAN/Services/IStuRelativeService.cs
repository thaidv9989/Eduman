using EDUMAN.Models;

namespace EDUMAN.Services
{
    public interface IStuRelativeService 
    {
        List<student_relative> GetList();
        student_relative? GetOne(int id);
        void Create(student_relative stuRelative);
        void Update(student_relative stuRelative);
        void Delete(int id);

    }
}
