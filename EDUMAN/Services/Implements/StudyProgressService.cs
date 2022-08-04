using EDUMAN.Models;
using EDUMAN.Repository;

namespace EDUMAN.Services.Implements
{
    public class StudyProgressService : IStudyProgressService
    {
        private readonly IStudyProgressRepository _studyProgress;

        public StudyProgressService(IStudyProgressRepository studyProgress)
        {
            _studyProgress = studyProgress;
        }
        public void Add(student_study_progress pro)
        {
            _studyProgress.Create(pro);
        }

        public void Del(int proId)
        {
            _studyProgress.Delete(proId);
        }

        public void Edit(student_study_progress pro)
        {
            _studyProgress.Update(pro);
        }

        public List<student_study_progress> GetList()
        {
            return _studyProgress.GetAll();
        }

        public student_study_progress? GetOne(int proId)
        {
            return _studyProgress.GetById(proId);
        }
    }
}
