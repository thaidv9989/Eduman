using EDUMAN.Data;
using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public class StuDisciplineRepository : IStuDisciplineRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StuDisciplineRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(student_discipline stuDis)
        {
            _dbContext.student_disciplines.Add(stuDis);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var rs = _dbContext.student_disciplines.Where(x => x.id == id).FirstOrDefault();
            if(rs != null)
            {
                _dbContext.student_disciplines.Remove(rs);
                _dbContext.SaveChanges();
            }
        }

        public void Edit(student_discipline stuDis)
        {
            var rs = _dbContext.student_disciplines.FirstOrDefault(x=>x.id == stuDis.id);
            if (rs != null)
            {
                rs.student_id = stuDis.student_id;
                rs.discipline_id = stuDis.discipline_id;
                rs.semester = stuDis.semester;
                rs.discipline_reason = stuDis.discipline_reason;
                rs.decision = stuDis.decision;
                rs.status = stuDis.status;
                rs.created_on = stuDis.created_on;
                rs.expired_on = stuDis.expired_on;
                rs.created_by = stuDis.created_by;
                rs.updated_on = stuDis.updated_on;
                rs.updated_by = stuDis.updated_by;
                _dbContext.student_disciplines.Update(rs);
                _dbContext.SaveChanges();
            }
        }

        public student_discipline? GetById(int id)
        {
            return _dbContext.student_disciplines.Where(x => x.id == id).FirstOrDefault();
        }

        public List<student_discipline> GetList()
        {
            return _dbContext.student_disciplines.ToList();
        }
    }
}
