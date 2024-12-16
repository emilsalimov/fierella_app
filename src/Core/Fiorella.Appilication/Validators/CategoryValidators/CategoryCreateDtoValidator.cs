using Fiorella.Appilication.DTOs.CategoryDTOs;
using FluentValidation;

namespace Fiorella.Appilication.Validators.CategoryValidators;
public class CategoryCreateDtoValidator :AbstractValidator <CategoryCreateDto>
{
    public CategoryCreateDtoValidator() 
    { 
       RuleFor(x=>x.name).NotNull().NotEmpty().MaximumLength(30);
       RuleFor(x=>x.description).MaximumLength(500);
    }

}
