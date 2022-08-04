using EDUMAN.Models;
using EDUMAN.Repository;

namespace EDUMAN.Services.Implements
{
    public class StuStayingService : IStuStayingService
    {
        private readonly IStuStayingRepository _stayingRepository;

        public StuStayingService(IStuStayingRepository stayingRepository)
        {
            _stayingRepository = stayingRepository;
        }
        public void Create(student_staying staying)
        {
            _stayingRepository.Add(staying);
        }

        public void Del(int id)
        {
            _stayingRepository.Delete(id);
        }

        public void Edit(student_staying staying)
        {
            _stayingRepository.Update(staying);
        }

        public List<student_staying> GetList()
        {
            return _stayingRepository.GetAll();
        }

        public student_staying? GetOne(int id)
        {
            return _stayingRepository.GetById(id);
        }
    }
}
