using EDUMAN.Models;

namespace EDUMAN.Repository
{
    public interface IClassRepository
    {
        List<e_class> GetAllClass();

        List<e_class> Search(int majorId);
        e_class? GetById(string id);
        void Add(e_class clas);
        void Update(e_class clas);
        void Del(string id);
        
    }
}
