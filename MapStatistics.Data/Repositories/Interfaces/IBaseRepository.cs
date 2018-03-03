using System.Linq;

namespace MapStatistics.Data.Repositories
{
    public interface IBaseRepository<T>
        where T : class
    {
        void Save();

        T GetById(int id);

        IQueryable<T> GetAll();
    }
}
