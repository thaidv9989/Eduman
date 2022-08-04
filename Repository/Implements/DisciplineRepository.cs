using EDUMAN.Data;
using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public class DisciplineRepository : IDisciplineRepository
    {
        private readonly ApplicationDbContext _context;

        public DisciplineRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void Add(discipline disc)
        {
            bool rs = _context.disciplines.Any(x => x.name == disc.name);
            if (rs == true)
            {
                throw new Exception("Something went wrong !!!!");
            }
            _context.disciplines.Add(disc);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var rs = _context.rewards.FirstOrDefault(x => x.reward_id == id);
            if(rs != null)
            {
                rs.status = "Deleted";
                _context.SaveChanges();
            }
            else
            {
                throw new Exception("Not found");
            }
        }

        public List<discipline> GetAll()
        {
            return _context.disciplines.ToList();
        }

        public discipline? GetOne(int id)
        {
            return _context.disciplines.FirstOrDefault(x => x.discipline_id == id);
        }

        public void Update(discipline disc)
        {
            var rs = _context.disciplines.Where(x => x.discipline_id == disc.discipline_id);
            try
            {
                if (rs != null)
                {
                    _context.disciplines.Update(disc);
                    _context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw new Exception("Invalid");
            }
        }
    }
}
