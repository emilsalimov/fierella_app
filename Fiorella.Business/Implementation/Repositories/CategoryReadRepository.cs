using Fiorella.Appilication.Abstraction.Repository;
using Fiorella.Domain.Entities;
using Fiorella.Persistence.Contexts;

namespace Fiorella.Persistence.Implementation.Repositories;
public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
{
    public CategoryReadRepository(AppDbContex context) : base(context)
    {

    }
}
