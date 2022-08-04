using EDUMAN.Models;

namespace EDUMAN.Repository
{
    public interface ISchoolYearRepository
    {
        List<school_year> GetAll();
        List<school_year> Search(int education_type_id);
        school_year? GetById(int id);
        void Add(school_year school);
        void Update(school_year school);
        void Delete(int id);
    }
}
