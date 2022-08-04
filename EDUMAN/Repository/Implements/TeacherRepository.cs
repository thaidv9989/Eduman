using EDUMAN.Data;
using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public TeacherRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(teacher tc)
        {
            _dbContext.teachers.Add(tc);
            _dbContext.SaveChanges();
        }

        public void Del(string id)
        {
            var rs = _dbContext.teachers.Where(x => x.teacher_id == id).FirstOrDefault();
            if(rs != null)
            {
                rs.status = "Deleted";
                _dbContext.SaveChanges();
            }
        }

        public void Edit(teacher tc)
        {
            var rs = _dbContext.teachers.Where(x => x.teacher_id == tc.teacher_id).FirstOrDefault();
            if (rs != null)
            {
                _dbContext.teachers.Update(rs);
                _dbContext.SaveChanges();
            }
        }

        public List<teacher> GetAll()
        {
            return _dbContext.teachers.ToList();
        }

        public teacher? GetByTeacherId(string id)
        {
            return _dbContext.teachers.FirstOrDefault(x => x.teacher_id == id);
        }
    }
}
