using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using Orders.Interfaces;
using Orders.Models;

namespace Orders.Executers
{
    public class BaseExecuter<T, TQ> : IExecuter<T>
        where T : OrderEntity<TQ>
        where TQ : class
    {
        protected readonly IOrderContext Context;
        protected BaseExecuter(IExecuter dbContext):this(dbContext.GetDbContext()){ }
        protected BaseExecuter(IOrderContext dbContext)
        {
            Context = dbContext;
        }
        protected BaseExecuter() : this(new OrderContext()){}

        public void Save()
        {
            Context.Save();
        }

        public IOrderContext GetDbContext()
        {
            return Context;
        }

        public string GetConnectionString()
        {
            return Context.ConnectionString;
        }

        public T Add(T entity)
        {
            return GetTable().Add(entity);
        }

        public T Get(int id)
        {
            return GetTable().SingleOrDefault(r => r.Id == id);
        }

        public void Update(T entity)
        {
            var victim = Get(entity.Id);
            victim?.Edit(entity);
        }

        public void Delete(int id)
        {
            var entity = Get(id);
            if(entity==null) return;
            GetTable().Remove(entity);
        }

        public void DeleteRange(Expression<Func<T, bool>> predicate)
        {
            var range = GetAll(predicate);
            GetTable().RemoveRange(range);
        }

        public IQueryable<T> GetAll()
        {
            return GetTable();
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate)
        {
            return GetTable().Where(predicate);
        }

        private DbSet<T> GetTable()
        {
            return Context.Set<T>();
        }
    }
}