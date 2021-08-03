using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parts.Registration.Domain.Repositories
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        void InsertRange(IEnumerable<TEntity> entity);
        void UpdateRange(IEnumerable<TEntity> entity);
        void DeleteRange(IEnumerable<TEntity> entity);
        Task InsertAsync(TEntity entity);
        IQueryable<TEntity> Get();
        int Save();
    }
}
