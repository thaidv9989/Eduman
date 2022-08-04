using EDUMAN.Models;

namespace EDUMAN.Services
{
    public interface ISchoolYearService
    {
        List<school_year> GetList();

        List<school_year> Search(int educationTypeId);
        school_year? GetOne(int id);
        void Add(school_year school);
        void Update(school_year school);
        void Delete(int id);
    }
}
