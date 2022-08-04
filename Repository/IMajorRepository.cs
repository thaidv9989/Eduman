using EDUMAN.Models;

namespace EDUMAN.Repository
{
    public interface IMajorRepository
    {
        List<major> GetAllMajor();

        List<major> Search(int schoolYearId);
        major? GetByMajorId(int id);
        void Add(major maj);
        void Update(major maj);
        void Delete(int id);
    }
}
