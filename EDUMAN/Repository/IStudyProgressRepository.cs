using EDUMAN.Models;

namespace EDUMAN.Repository
{
    public interface IStudyProgressRepository
    {
        List<student_study_progress> GetAll();
        student_study_progress? GetById(int id);
        void Create(student_study_progress progress);
        void Update(student_study_progress progress);
        void Delete(int id);
    }
}
