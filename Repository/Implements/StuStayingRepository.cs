using EDUMAN.Data;
using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public class StuStayingRepository : IStuStayingRepository
    {
        private readonly ApplicationDbContext _context;

        public StuStayingRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(student_staying staying)
        {
            _context.student_stayings.Add(staying);
            _context.SaveChanges();

        }

        public void Delete(int id)
        {
            var rs = _context.student_stayings.FirstOrDefault(x => x.id == id);
            if (rs != null)
            {
                _context.student_stayings.Remove(rs);
                _context.SaveChanges();
            }
        }

        public List<student_staying> GetAll()
        {
            return _context.student_stayings.ToList();
        }

        public student_staying? GetById(int id)
        {
            return _context.student_stayings.FirstOrDefault(x=>x.id == id);
        }

        public void Update(student_staying staying)
        {
            var rs = _context.student_stayings.FirstOrDefault(x => x.id == staying.id);
            if (rs != null)
            {
                _context.student_stayings.Update(rs);
                _context.SaveChanges();
            }
        }
    }
}
