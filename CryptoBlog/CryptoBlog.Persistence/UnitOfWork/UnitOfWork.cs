using CryptoBlog.Infrastructure.Data.DbContext;

namespace CryptoBlog.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BlogAppContext _context;

        public UnitOfWork(BlogAppContext context)
        {
            _context = context;
        }

        public Task<int> SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }

}
