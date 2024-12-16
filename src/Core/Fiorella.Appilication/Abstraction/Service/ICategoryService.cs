using Fiorella.Appilication.DTOs.CategoryDTOs;

namespace Fiorella.Appilication.Abstraction.Service;
public interface ICategoryService
{
    Task CreateAsync(CategoryCreateDto categoryCreateDto);
    Task<CategoryGetDto> GetByIdAsync(int id);
    Task<List<CategoryGetDto>>GetAllAsync();
}
