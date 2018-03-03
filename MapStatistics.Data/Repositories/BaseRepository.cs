using System.Data.Entity;
using System.Linq;

namespace MapStatistics.Data.Repositories
{
    public abstract class BaseRepository<T, TEntity> : IBaseRepository<T>
        where T : class
        where TEntity : DbContext, new()
    {
        protected TEntity Entities { get; }

        public DbSet<T> Set => Entities.Set<T>();

        public IQueryable<T> Items => Set.AsQueryable();

        protected BaseRepository()
        {
            Entities = new TEntity();
        }

        public virtual void Save()
        {
            Entities.SaveChanges();
        }

        public virtual T GetById(int id)
        {
            return Set.Find(id);
        }

        public virtual IQueryable<T> GetAll()
        {
            return Items;
        }
    }
}
