using EDUMAN.Models;
using EDUMAN.Models.Responses;

namespace EDUMAN.Services
{
    public interface IStudentService
    {
        PageList<student> GetAll(PageAction pageAction) ;
        List<student> Search(string classId, string name, bool gender, string country, string phone, string status);
        List<student> GetAllUsers();
        IEnumerable<studentDetails>? ListDetails(string id);
        student DisableUser(string id);
        void Create(student stu);
        
        void Update(student stu);
        student? GetStudent(string id);
    }
}
