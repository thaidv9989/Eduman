using EDUMAN.Models;
using EDUMAN.Repository;

namespace EDUMAN.Services.Implements
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;

        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public void CreateTeacher(teacher tc)
        {
            _teacherRepository.Add(tc);
        }

        public void Del(string id)
        {
            _teacherRepository.Del(id);
        }

        public List<teacher> GetAllTeachers()
        {
            return _teacherRepository.GetAll();
        }

        public teacher? GetTeacher(string id)
        {
            return _teacherRepository.GetByTeacherId(id);
        }

        public void Update(teacher tc)
        {
            _teacherRepository.Edit(tc);
        }
    }
}
