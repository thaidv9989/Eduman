using EDUMAN.Data;
using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public class MajorRepository : IMajorRepository
    {
        private readonly ApplicationDbContext _context;

        public MajorRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(major maj)
        {
            bool rs = _context.majors.Any(x => x.major_name == maj.major_name);
            if (rs == true)
            {
                throw new Exception("Major is already exist!!!!");
            }
            else
            {
                _context.majors.Add(maj);
                _context.SaveChanges();
            }

            
        }

        public void Delete(int id)
        {
            var rs = _context.majors.Where(x => x.major_id == id).FirstOrDefault();
            if (rs != null)
            {
                rs.status = "Deleted";
                _context.SaveChanges();
            }
        }

        public List<major> GetAllMajor()
        {
            return _context.majors.ToList();
        }

        public major? GetByMajorId(int id)
        {
            return _context.majors.FirstOrDefault(x => x.major_id == id);
        }

        public List<major> Search(int schoolYearId)
        {
            return _context.majors.Where(x => x.school_year_id == schoolYearId).ToList();    
        }

        public void Update(major maj)
        {
            var rs = _context.majors.FirstOrDefault(x => x.major_id == maj.major_id);
            if (rs != null)
            {
                _context.majors.Update(rs);
                _context.SaveChanges();
            }
        }
    }
}
