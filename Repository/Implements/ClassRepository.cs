using EDUMAN.Data;
using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public class ClassRepository : IClassRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public ClassRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Add(e_class clas)
        {
            bool rs = _dbContext.classes.Any(x => x.class_name == clas.class_name);
            if(rs == true)
            {
                throw new Exception("Class name is already exist!!!!");
            }
            else
            {
                _dbContext.classes.Add(clas);
                _dbContext.SaveChanges();
            }
            
        }

        public void Del(string id)
        {
            var rs = _dbContext.classes.FirstOrDefault(x => x.class_id == id);
            if (rs != null)
            {
                /*_dbContext.classes.Remove(rs);*/
                rs.status = "Deleted";
                _dbContext.SaveChanges();
            }
        }

        public List<e_class> GetAllClass()
        {
            return _dbContext.classes.ToList();
        }

        public e_class? GetById(string id)
        {
            return _dbContext.classes.Where(x => x.class_id == id).FirstOrDefault();
        }

        public List<e_class> Search(int majorId)
        {
            return _dbContext.classes.Where(x => x.major_id == majorId).ToList();
        }

        public void Update(e_class clas)
        {
            var rs = _dbContext.classes.FirstOrDefault(x => x.class_id == clas.class_id);
            if (rs != null)
            {
                _dbContext.classes.Update(rs);
                _dbContext.SaveChanges();
            }
        }
    }
}
