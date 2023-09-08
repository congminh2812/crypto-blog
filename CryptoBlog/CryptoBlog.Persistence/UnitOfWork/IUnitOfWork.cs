namespace CryptoBlog.Infrastructure.Data.UnitOfWork
{
    public interface IUnitOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
