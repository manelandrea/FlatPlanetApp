using Project.Core;
using System.Linq;

namespace Project.Data
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Table { get; }
        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
    }
}
