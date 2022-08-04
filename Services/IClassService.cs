using EDUMAN.Models;

namespace EDUMAN.Services
{
    public interface IClassService
    {
        List<e_class> GetList();

        List<e_class> Search(int majorId);
        e_class? GetOne(string id);
        void Create(e_class clas);
        void Update(e_class clas);
        void Delete(string id);
    }
}
