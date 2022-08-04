using EDUMAN.Models;
using EDUMAN.Repository;

namespace EDUMAN.Services.Implements
{
    public class StuRelativeService : IStuRelativeService
    {
        private readonly IStuRelativeRepository _stuRelativeRepository;

        public StuRelativeService(IStuRelativeRepository stuRelativeRepository)
        {
            _stuRelativeRepository = stuRelativeRepository;
        }
        public void Create(student_relative stuRelative)
        {
            _stuRelativeRepository.Add(stuRelative);
        }

        public void Delete(int id)
        {
            _stuRelativeRepository.Del(id);
        }

        public List<student_relative> GetList()
        {
            return _stuRelativeRepository.GetAll();
        }

        public student_relative? GetOne(int id)
        {
            return _stuRelativeRepository.GetById(id);
        }

        public void Update(student_relative stuRelative)
        {
            _stuRelativeRepository.Edit(stuRelative);
        }
    }
}
