using EDUMAN.Models;
using EDUMAN.Models.Responses;

namespace EDUMAN.Repository
{
    public interface IStudentRepository : IRepositoryBase<student>
    {
        PageList<student> GetAll(PageAction pageAction);
        student DisableUser(string id);
        void Create(student stu);
        void Update(student stu);
        IEnumerable<studentDetails>? Details(string id);
        
        student? GetStudent(string id);
        List<student> GetAllStudents();

        List<student> Search(string classId, string name, bool gender, string country, string phone, string status);

    }
}
