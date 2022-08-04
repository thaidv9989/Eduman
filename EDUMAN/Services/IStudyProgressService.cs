
using EDUMAN.Models;

namespace EDUMAN.Services
{
    public interface IStudyProgressService
    {
        List<student_study_progress> GetList();
        student_study_progress? GetOne(int proId);

        void Add(student_study_progress pro);
        void Edit(student_study_progress pro);
        void Del(int proId);
    }
}
