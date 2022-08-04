using EDUMAN.Data;
using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public class StuRelativeRepository : IStuRelativeRepository
    {
        private readonly ApplicationDbContext _context;

        public StuRelativeRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(student_relative stuRelative)
        {
            _context.student_relatives.Add(stuRelative);
            _context.SaveChanges();
        }

        public void Del(int id)
        {
            var rs = _context.student_relatives.Where(x => x.id == id).FirstOrDefault();
            if(rs != null)
            {
                _context.student_relatives.Remove(rs);
                _context.SaveChanges();
            }
            
        }

        public void Edit(student_relative stuRelative)
        {
            var rs = _context.student_relatives.FirstOrDefault(x => x.id == stuRelative.id);
        }

        public List<student_relative> GetAll()
        {
            return _context.student_relatives.ToList();
        }

        public student_relative? GetById(int id)
        {
            return _context.student_relatives.FirstOrDefault(x => x.id == id);
        }
    }
}
