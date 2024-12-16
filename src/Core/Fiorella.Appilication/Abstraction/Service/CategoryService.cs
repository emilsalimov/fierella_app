using Fiorella.Appilication.Abstraction.Repository;
using Fiorella.Appilication.DTOs.CategoryDTOs;
using Fiorella.Domain.Entities;
using System.Runtime.Serialization;

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
    public async Task CreateAsync(CategoryCreateDto categoryCreateDto)
    {
        Category? dbCategory = await _readRepository
            .GetByExpressionAsync(c => c.Name.ToLower().Equals(categoryCreateDto.name.ToLower()));
        if (dbCategory is not null) 
        {
            throw new DublicatedException("Dublicated Category name !");
        }
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

[Serializable]
internal class DublicatedException : Exception
{
    public DublicatedException()
    {
    }

    public DublicatedException(string? message) : base(message)
    {
    }

    public DublicatedException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected DublicatedException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
}