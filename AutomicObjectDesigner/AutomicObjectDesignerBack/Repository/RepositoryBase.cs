using System.Linq.Expressions;
using AutomicObjectDesignerBack.Data;
using Microsoft.EntityFrameworkCore;

namespace AutomicObjectDesignerBack.Repository;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    public AppDatabaseContext DatabaseContext { get; set; }
    public IQueryable<T> GetAll()
    {
        return DatabaseContext.Set<T>().AsNoTracking();
    }

    public IQueryable<T> FindbyCondition(Expression<Func<T, bool>> expression)
    {
        return DatabaseContext.Set<T>().Where(expression).AsNoTracking();
    }

    public void Create(T entity)
    {
        DatabaseContext.Set<T>().Add(entity);
    }

    public void Delete(T entity)
    {
        DatabaseContext.Set<T>().Remove(entity);
    }

    public void Update(T entity)
    {
        DatabaseContext.Set<T>().Update(entity);
    }
}