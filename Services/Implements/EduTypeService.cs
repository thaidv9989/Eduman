using EDUMAN.Models;
using EDUMAN.Repository;

namespace EDUMAN.Services.Implements
{
    public class EduTypeService : IEduTypeService
    {
        private readonly IEducationTypeRepository _eduTypeRepository;

        public EduTypeService(IEducationTypeRepository eduTypeRepository)
        {
            _eduTypeRepository = eduTypeRepository;
        }
        public void Create(education_type edu)
        {
            _eduTypeRepository.Add(edu);
        }

        public void Del(int id)
        {
            _eduTypeRepository.Del(id);
        }

        public List<education_type> GetList()
        {
            return _eduTypeRepository.GetAll();
        }

        public education_type? GetOne(int id)
        {
            return _eduTypeRepository.GetById(id);
        }

        public void Update(education_type edu)
        {
            _eduTypeRepository.Edit(edu);
        }
    }
}
