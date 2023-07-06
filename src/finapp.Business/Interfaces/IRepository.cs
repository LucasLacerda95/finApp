using System.Linq.Expressions;
using System.Xml;
using finapp.Business.Models;

namespace finapp.Business.Interfaces
{

    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task Add(TEntity entity);
        Task<TEntity> GetById(Guid id);
        Task<List<TEntity>> GetAll();
        Task Update(TEntity entity);
        Task Remove(Guid id);
        Task<IEnumerable<TEntity>> Find(Expression<Func<TEntity, bool>> predicate);//pesquisar
        Task<int> SaveChanges();
    }
}