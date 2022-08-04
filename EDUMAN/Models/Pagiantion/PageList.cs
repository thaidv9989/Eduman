namespace EDUMAN.Models.Responses
{
    public class PageList<T> : List<T>
    {
        public int CurrentPage { get; private set; }
        public int TotalPages { get; private set; }
        public int PageSize { get; private set; }
        public int TotalCount { get; private set; }
        public bool Previous => CurrentPage > 1;
        public bool Next => CurrentPage < TotalPages;

        public PageList(List<T> items, int count, int pageNumber, int pageSize)
        {
            TotalCount = count;
            TotalPages = (int)Math.Ceiling(count /(double)pageSize);
            PageSize = pageSize;
            CurrentPage = pageNumber;
            AddRange(items);
        }
        public static PageList<T> GetPagedList(IQueryable<T> source, int pageNumber, int pageSize)
        {
            var count = source.Count();
            var items = source.Skip((pageNumber - 1) * pageSize).Take(pageSize).ToList();
            return new PageList<T>(items, count, pageNumber, pageSize); 
        }

        
    }
    
    
}
