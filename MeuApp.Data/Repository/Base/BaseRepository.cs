using MeuApp.Data.Context;
using MeuApp.Domain.Interfaces.Repository.Base;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace MeuApp.Data.Repository.Base
{

    public abstract class BaseRepository<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly MeuAppDbContext _vMeuAppDbContext;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepository(MeuAppDbContext _pMeuAppDbContext)
        {
            _vMeuAppDbContext = _pMeuAppDbContext;
            DbSet = _pMeuAppDbContext.Set<TEntity>();
        }

        public virtual async Task<TEntity> Add(TEntity entity)
        {
            await _vMeuAppDbContext.Set<TEntity>().AddAsync(entity);
            await _vMeuAppDbContext.SaveChangesAsync();
            return entity;
        }
        
        public virtual async Task AddRange(IList<TEntity> entity)
        {
            await DbSet.AddRangeAsync(entity);
        }

        public virtual async Task<TEntity> Delete(long Id)
        {
            var entity = await _vMeuAppDbContext.Set<TEntity>().FindAsync(Id);
            if (entity == null)
                return entity;

            _vMeuAppDbContext.Set<TEntity>().Remove(entity);
            await _vMeuAppDbContext.SaveChangesAsync();

            return entity;
        }

        public TEntity Get(Func<TEntity, bool> predicate)
        {
            return _vMeuAppDbContext.Set<TEntity>().Where(predicate).FirstOrDefault();
        }

        public IQueryable<TEntity> GetAll(Func<TEntity, bool> predicate)
        { 
            return _vMeuAppDbContext.Set<TEntity>().Where(predicate).AsQueryable();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public async Task<TEntity> GetById(long Id)
        {
            var result = await _vMeuAppDbContext.Set<TEntity>().FindAsync(Id);
            return result;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _vMeuAppDbContext.Entry(entity).State = EntityState.Modified;
            await _vMeuAppDbContext.SaveChangesAsync();
            return entity;
        }

        public async Task UpdateRange(IEnumerable<TEntity> models)
        {
            if (models == null)
                throw new ArgumentNullException(nameof(models));

            DbSet.UpdateRange(models);
        }
            

            
        
    }
}