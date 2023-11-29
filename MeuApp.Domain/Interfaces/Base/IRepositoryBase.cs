using System.Linq.Expressions;

namespace MeuApp.Domain.Interfaces.Base
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        Task<TEntity> Add(TEntity entity);
        Task addRange(IList<TEntity> entity);
        Task<TEntity> Upadate(TEntity entity);
        Task UpdateRange(IEnumerable<TEntity> entity);
        Task<TEntity>Delete(long Id);
        Task<TEntity> GetById(long Id);
        IQueryable<TEntity> GetAll(Func<TEntity,bool> predicate);
        Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate);
        TEntity Get(Func<TEntity, bool> predicate);



    }
}
