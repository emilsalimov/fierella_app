using Fiorella.Domain.Entities;

namespace Fiorella.Appilication.Abstraction.Repository;
public interface IWriteRepository <T> : IRepository<T> where T : BaseEntity, new()
{ 
    Task AddAsync(T entity);
    Task AddRangeAsync(ICollection<T> entity);
    void Remove(T entity);
    void RemoveRange(ICollection<T> entities);
    void Update(T entity);
    Task SaveChangeAsync();

}
