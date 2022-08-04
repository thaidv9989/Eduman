using EDUMAN.Data;
using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public class SchoolYearRepository : ISchoolYearRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public SchoolYearRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(school_year school)
        {
            bool rs = _dbContext.school_years.Any(x => x.school_year_name == school.school_year_name);
            if(rs == true)
            {
                throw new Exception();
            }
            _dbContext.school_years.Add(school);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var rs = _dbContext.school_years.Where(x => x.school_year_id == id).FirstOrDefault();
            if (rs != null)
            {
                rs.status = "Deleted";
                _dbContext.SaveChanges();
            }
        }

        public List<school_year> GetAll()
        {
            return _dbContext.school_years.ToList();
        }

        public school_year? GetById(int id)
        {
            return _dbContext.school_years.FirstOrDefault(x => x.education_type_id == id);
        }

        public List<school_year> Search(int education_type_id)
        {
            return _dbContext.school_years.Where(x => x.education_type_id == education_type_id).ToList();
        }

        public void Update(school_year school)
        {
            var rs = _dbContext.school_years.FirstOrDefault(x => x.school_year_id == school.school_year_id);
            if (rs != null)
            {
                _dbContext.school_years.Update(rs);
                _dbContext.SaveChanges();
            }
        }
    }
}
