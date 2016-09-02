using System;
using System.Linq;
using System.Linq.Expressions;

namespace Orders.Interfaces
{
    public interface IExecuter<T>: IExecuter
    {
        T Add(T endtity);
        T Get(int id);
        void Update(T entity);
        void Delete(int id);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate);
    }

    public interface IExecuter
    {
        void Save();
        IOrderContext GetDbContext();
        string GetConnectionString();
    }
}