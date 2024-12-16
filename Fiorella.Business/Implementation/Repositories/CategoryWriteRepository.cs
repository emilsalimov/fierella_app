using Fiorella.Appilication.Abstraction.Repository;
using Fiorella.Domain.Entities;
using Fiorella.Persistence.Contexts;

namespace Fiorella.Persistence.Implementation.Repositories;
public class CategoryWriteRepository : WriteRepository<Category>, ICategoryWriteRepository
{
    public CategoryWriteRepository(AppDbContex context) : base(context)
    {
    }
}
