using EDUMAN.Models;

namespace EDUMAN.Services
{
    public interface IMajorService
    {
        List<major> GetList();

        List<major> Search(int schoolYearId);
        major? GetDetail(int id);
        void Create(major maj);
        void Edit(major maj);
        void Del(int id);

    }
}
