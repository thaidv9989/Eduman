namespace EDUMAN.Repository
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll();
    }
}
