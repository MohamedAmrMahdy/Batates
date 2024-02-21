using System.Linq.Expressions;

namespace Batates.Repo.IRepo
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes);
        T Get(Expression <Func<T, bool>> predict);
        T Get(Expression<Func<T, bool>> predict, params Expression<Func<T, object>>[] includes);
        int Create(T item);
        int Delete(T item);
    }
}
