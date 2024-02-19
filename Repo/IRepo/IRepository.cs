using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Batates.Repo.IRepo
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes);
        T Get(Expression <Func<T, bool>> predict);
        T Get(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includes);
        int Create(T item);
        int Delete(T item);
    }
}
