using EDUMAN.Data;
using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public class EducationTypeRepository : IEducationTypeRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public EducationTypeRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(education_type edu)
        {
            bool rs = _dbContext.education_types.Any(x => x.education_type_name == edu.education_type_name);
            if (rs == true)
            {
                throw new Exception();
            }
            _dbContext.education_types.Add(edu);
            _dbContext.SaveChanges();
        }

        public void Del(int id)
        {
            var rs = _dbContext.education_types.FirstOrDefault(x => x.education_type_id == id);
            if(rs != null)
            {
                _dbContext.education_types.Remove(rs);
                _dbContext.SaveChanges();
            }
        }

        public void Edit(education_type edu)
        {
            var rs = _dbContext.education_types.FirstOrDefault(x => x.education_type_id == edu.education_type_id);
            if (rs != null)
            {
                _dbContext.education_types.Update(rs);
                _dbContext.SaveChanges();
            }
        }

        public List<education_type> GetAll()
        {
            return _dbContext.education_types.ToList();
        }

        public education_type? GetById(int id)
        {
            return _dbContext.education_types.Where(x => x.education_type_id == id).FirstOrDefault();
        }
    }
}
