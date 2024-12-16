using Fiorella.Appilication.Abstraction.Repository;
using Fiorella.Appilication.DTOs.CategoryDTOs;

namespace Fiorella.Appilication.Abstraction.Service;

public class CategoryService : ICategoryService
{
    private readonly ICategoryReadRepository _readRepository; 
    private readonly ICategoryWriteRepository _writeRepository;

    public CategoryService(ICategoryReadRepository _readRepository,
                         ICategoryWriteRepository _writeRepository)
    {
        _readRepository = _readRepository;
        _writeRepository = _writeRepository;
    }
    public Task CreateAsync(CategoryCreateDto categoryCreateDto)
    {
        throw new NotImplementedException();
    }

    public override bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

    public Task<List<CategoryGetDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<CategoryGetDto> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }

    public override string? ToString()
    {
        return base.ToString();
    }
}
