using Fiorella.Appilication.Abstraction.Repository;
using Fiorella.Domain.Entities;
using Fiorella.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Fiorella.Persistence.Implementation.Repositories;
public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity, new()
{
    private readonly AppDbContex _context;
    public DbSet<T> Table => _context.Set<T>();
    public ReadRepository(AppDbContex context)
    {
        _context = context;
    }
    
    public IQueryable<T> GetAll(bool isTracking = true, params string[] includes)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetAllExpression(Expression<Func<T, bool>> expression, int take, int skip, bool isTracking = true, params string[] includes)
    {
        throw new NotImplementedException();
    }

    public IQueryable<T> GetAllFilteredOrderBy(Expression<Func<T, bool>> expression, int take, int skip, Expression<Func<T, object>> expressionOrder, bool isOrdered = true, bool isTracking = true, params string[] includes)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByExpression(Expression<Func<T, bool>> expression)
    {
        throw new NotImplementedException();
    }

    public Task<T> GetByIdAsync(string Id)
    {
        throw new NotImplementedException();
    }
}
