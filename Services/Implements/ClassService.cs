using EDUMAN.Models;
using EDUMAN.Repository;

namespace EDUMAN.Services.Implements
{
    public class ClassService : IClassService
    {
        private readonly IClassRepository _classRepository;

        public ClassService(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }
        public void Create(e_class clas)
        {
            
            _classRepository.Add(clas);
        }

        public void Delete(string id)
        {
            _classRepository.Del(id);
        }

        public List<e_class> GetList()
        {
            return _classRepository.GetAllClass();
        }

        public e_class? GetOne(string id)
        {
            return _classRepository.GetById(id);
        }

        public List<e_class> Search(int majorId)
        {
            return _classRepository.Search(majorId);
        }

        public void Update(e_class clas)
        {
            _classRepository.Update(clas);
        }
    }
}
