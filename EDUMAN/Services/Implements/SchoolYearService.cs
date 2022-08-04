using EDUMAN.Models;
using EDUMAN.Repository;

namespace EDUMAN.Services.Implements
{
    public class SchoolYearService : ISchoolYearService
    {
        private readonly ISchoolYearRepository _schoolYearRepository;

        public SchoolYearService(ISchoolYearRepository schoolYearRepository)
        {
            _schoolYearRepository = schoolYearRepository;
        }
        public void Add(school_year school)
        {
            _schoolYearRepository.Add(school);
        }

        public void Delete(int id)
        {
            _schoolYearRepository.Delete(id);
        }

        public List<school_year> GetList()
        {
            return _schoolYearRepository.GetAll();
        }

        public school_year? GetOne(int id)
        {
            return _schoolYearRepository.GetById(id);
        }

        public List<school_year> Search(int educationTypeId)
        {
            return _schoolYearRepository.Search(educationTypeId);
        }

        public void Update(school_year school)
        {
            _schoolYearRepository.Update(school);
        }
    }
}
