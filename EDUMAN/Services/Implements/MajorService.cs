using EDUMAN.Models;
using EDUMAN.Repository;

namespace EDUMAN.Services.Implements
{
    public class MajorService : IMajorService
    {
        private readonly IMajorRepository _majorRepository;

        public MajorService(IMajorRepository majorRepository)
        {
            _majorRepository = majorRepository;
        }
        public void Create(major maj)
        {
            _majorRepository.Add(maj);
        }

        public void Del(int id)
        {
            _majorRepository.Delete(id);
        }

        public void Edit(major maj)
        {
            _majorRepository.Update(maj);
        }

        public major? GetDetail(int id)
        {
            return _majorRepository.GetByMajorId(id);
        }

        public List<major> GetList()
        {
            return _majorRepository.GetAllMajor();
        }

        public List<major> Search(int schoolYearId)
        {
            return _majorRepository.Search(schoolYearId);
        }
    }
}
