using EDUMAN.Constants;
using EDUMAN.Data;

using EDUMAN.Models;
using EDUMAN.Models.Responses;

namespace EDUMAN.Repository.Implements
{
    public class StudentRepository : RepositoryBase<student>, IStudentRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public StudentRepository(ApplicationDbContext dbcontext) : base(dbcontext)
        {
            _dbContext = dbcontext;
        }
        public void Create(student stu)
        {   
            
            _dbContext.students.Add(stu);
            _dbContext.SaveChanges();
        }

        public student DisableUser(string id)
        {
            var stu = _dbContext.students.FirstOrDefault(x => x.student_id == id);
            if (stu != null)
            {
                stu.status = "deleted";
                /*_dbContext.students.Remove(stu);*/
                _dbContext.SaveChanges();
            }
            return stu;
        }

        public PageList<student> GetAll(PageAction pageAction)
        {
            return PageList<student>.GetPagedList(FindAll().OrderBy(s=>s.student_id), pageAction.PageNumber, pageAction.PageSize);
        }

        public student? GetStudent(string id)
        {
            return _dbContext.students.FirstOrDefault(x => x.student_id == id);
        }

        public List<student> GetAllStudents()
        {
            return _dbContext.students.ToList();
        }

        public void Update(student stu)
        {
            
            try
            {
                _dbContext.students.Update(stu);
                _dbContext.SaveChanges();
               
            }
            catch (Exception exception)
            {
                
                throw new Exception(exception.Message);
            }
        }

        public  List<student> Search(string classId, string name, bool gender, string country, string phone, string status)
        {
            return  _dbContext.students
                .Where(x => x.fullname == name
                || x.class_id == classId
                || x.gender == gender 
                || x.country == country
                || x.phone == phone
                || x.status == status
                ).ToList();
        }

        public IEnumerable<studentDetails>? Details(string id)
        {

            try
            {
                var detail = (from s in _dbContext.students
                              join sre in _dbContext.student_relatives on s.student_id equals sre.student_id
                              join srew in _dbContext.student_rewards on s.student_id equals srew.student_id
                              where(s.student_id == id)
                              select new studentDetails()
                              {
                                  student_id = s.student_id,
                                  img = s.img,
                                  fullname = s.fullname,
                                  gender = s.gender,
                                  country = s.country,
                                  date_of_birth = s.date_of_birth,
                                  place_of_birth = s.place_of_birth,
                                  domicile = s.domicile,
                                  household = s.household,
                                  ethnicity = s.ethnicity,
                                  religion = s.religion,
                                  recruitment_area = s.recruitment_area,
                                  subject = s.subject,
                                  morality = s.morality,
                                  education_level = s.education_level,
                                  policy_type = s.policy_type,
                                  family_category = s.family_category,
                                  communist_youth_day = s.communist_youth_day,
                                  communist_party_day = s.communist_party_day,
                                  identity_number = s.identity_number,
                                  identity_date = s.identity_date,
                                  identity_place = s.identity_place,
                                  bank_account = s.bank_account,
                                  email = s.email,
                                  contact_address = s.contact_address,
                                  phone = s.phone,
                                  class_id = s.class_id,
                                  description = s.description,
                                  state = s.state,
                                  status = s.status,
                                  relative_type = sre.relative_type,
                                  relative_fullname = sre.relative_fullname,
                                  DOB = sre.date_of_birth,
                                  households = sre.household,
                                  job = sre.job,
                                  semester = srew.semester,
                                  reward_reason = srew.reward_reason,
                                  decision = srew.decision,
                                  Day = srew.created_on,
                                  created_by = s.created_by,
                                  created_on = s.created_on,
                                  updated_by = s.updated_by,
                                  updated_on = s.updated_on
                              }).ToList();
                return detail;
            }
            catch (Exception)
            {

                throw new Exception(Messages.NOTFOUND_REQUEST);
            }
        }

        
    }
}
