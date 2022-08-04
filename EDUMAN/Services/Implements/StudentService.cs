using EDUMAN.Constants;
using EDUMAN.Models;
using EDUMAN.Models.Responses;
using EDUMAN.Repository;

namespace EDUMAN.Services.Implements
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public void Create(student stu)
        {
            
            _studentRepository.Create(stu);
        }

        public student DisableUser(string id)
        {
           return _studentRepository.DisableUser(id);
        }

        public PageList<student> GetAll(PageAction pageAction)
        {
            return _studentRepository.GetAll(pageAction);
        }

        public List<student> GetAllUsers()
        {
            return _studentRepository.GetAllStudents();
        }

        public student? GetStudent(string id)
        {
            return _studentRepository.GetStudent(id);
        }

        public IEnumerable<studentDetails>? ListDetails(string id)
        {
            return _studentRepository.Details(id);
        }

        public List<student> Search(string classId, string name, bool gender, string country, string phone, string status)
        {
            return  _studentRepository.Search(classId, name, gender, country, phone, status);
        }

        public void Update(student stu)
        {
            _studentRepository.Update(stu);
        }
    }
}
