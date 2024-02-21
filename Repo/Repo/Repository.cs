using Batates.Data;
using Batates.Models;
using Batates.Repo.IRepo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Batates.Repo.Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDbContext DB;
        internal DbSet<T> DbSet;
        public Repository(ApplicationDbContext dB)
        {
            DB = dB;
            DbSet = DB.Set<T>();
        }
        public int Create(T item)
        {
            DbSet.Add(item);
            return DB.SaveChanges();
        }

        public int Delete(T item)
        {
            DbSet.Remove(item);
            return DB.SaveChanges();
        }

        public T Get(Expression<Func<T, bool>> predict ) => DbSet.FirstOrDefault(predict)!;
        public T Get(Expression<Func<T, bool>> predict, params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = DbSet;

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = includes.Aggregate(query, (current, include) => current.Include(include));
                }
            }
            return query.FirstOrDefault(predict)!;
        }

        public IEnumerable<T> GetAll() => DbSet.ToList()!;
        public IEnumerable<T> GetAll(params Expression<Func<T, object>>[] includes)
        {
            IQueryable<T> query = DbSet;

            if (includes != null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }
            }

            return query.ToList()!;
        }
    }
}
