using CryptoBlog.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using CryptoBlog.Persistence.DbContext;
using CryptoBlog.Persistence.Repositories.Interfaces;

namespace CryptoBlog.Persistence.Repositories.Implements
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        private readonly BlogAppContext _context;

        public Repository(BlogAppContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().AsNoTracking().ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(s => s.Id == id);
        }

        public Task UpdateAsync(T entity)
        {
            _context.Update(entity);
            _context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            return Task.CompletedTask;
        }

    }

}
