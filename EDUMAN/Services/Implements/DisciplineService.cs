using EDUMAN.Models;
using EDUMAN.Repository.Implements;

namespace EDUMAN.Services.Implements
{
    public class DisciplineService : IDisciplineService
    {
        private readonly IDisciplineRepository _disRepo;

        public DisciplineService(IDisciplineRepository disRepo)
        {
            _disRepo = disRepo;
        }
        public void Add(discipline discip)
        {
            _disRepo.Add(discip);
        }

        public void Delete(int id)
        {
            _disRepo.Delete(id);    
        }

        public List<discipline> GetAll()
        {
            return _disRepo.GetAll();
        }

        public discipline? GetOne(int id)
        {
            return _disRepo.GetOne(id);
        }

        public void Update(discipline discip)
        {
            _disRepo.Update(discip);
        }
    }
}
