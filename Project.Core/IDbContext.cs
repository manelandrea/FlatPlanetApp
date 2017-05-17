using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace Project.Core
{
    public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        DbEntityEntry<T> Entry<T>(T entity) where T : BaseEntity;
        int SaveChanges();
    }
}
