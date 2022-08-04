using EDUMAN.Constants;
using EDUMAN.Data;
using EDUMAN.Models;

namespace EDUMAN.Repository.Implements
{
    public class StudyProgressRepository : IStudyProgressRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StudyProgressRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Create(student_study_progress progress)
        {
            _dbContext.student_study_progresses.Add(progress);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var rs = _dbContext.student_study_progresses.FirstOrDefault(x => x.id == id);
            if(rs != null)
            {
                try
                {
                    _dbContext.student_study_progresses.Remove(rs);
                    _dbContext.SaveChanges();
                }
                catch (Exception)
                {

                    throw new Exception("Something went wrong!!!");
                }
            }
            
        }

        public List<student_study_progress> GetAll()
        {
            return _dbContext.student_study_progresses.ToList();
        }

        public student_study_progress? GetById(int id)
        {
            return _dbContext.student_study_progresses.Where(x => x.id == id).FirstOrDefault();
        }

        public void Update(student_study_progress progress)
        {
            var rs = _dbContext.student_study_progresses.FirstOrDefault(x => x.id == progress.id);
            if (rs != null)
            {
                try
                {
                    _dbContext.student_study_progresses.Update(rs);
                    _dbContext.SaveChanges();
                }
                catch (Exception)
                {

                    throw new Exception("Something went wrong!!!");
                }
            }
        }
    }
}
