using Fiorella.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Fiorella.Appilication.Abstraction.Repository;
public interface IRepository <T> where T : BaseEntity, new()
{
    public DbSet<T> Table { get; }
    Task AddAsync(T entity);
    Task AddRangeAsync(ICollection<T>entity);
    void Remove(T entity);
    void Update(T entity);
    IQueryable<T> GetAll(bool isTracking=true, params string[] includes);
    IQueryable<T> GetAllExpression(Expression<Func<T, bool>>expression, int take, int skip, bool isTracking=true, params string[] includes);
    IQueryable<T> GetAllFilteredOrderBy(Expression<Func<T, bool>>expression, int take, int skip,Expression<Func<T, object>>expressionOrder, bool isOrdered=true, bool isTracking = true, params string[] includes);
    Task<T> GetByExpression(Expression<Func<T, bool>> expression);
    Task<T> GetByIdAsync(string Id);
    Task SaveChangeAsync();
}
