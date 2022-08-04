using EDUMAN.Data;
using Microsoft.EntityFrameworkCore;

namespace EDUMAN.Repository.Implements
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected ApplicationDbContext RepositoryBaseContext { get; set; }


        public RepositoryBase(ApplicationDbContext repositoryContext)
        {
            this.RepositoryBaseContext = repositoryContext;
        }
        public IQueryable<T> FindAll()
        {
            return this.RepositoryBaseContext.Set<T>().AsNoTracking();
        }
    }
}
