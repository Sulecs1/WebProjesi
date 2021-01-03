using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using BlogProjem.DTO.DTOs.CategoryDtos;

namespace BlogProjem.Business.ValidationRules.FluentValidation
{
    public class CategoryAddValidator : AbstractValidator<CategoryAddDto>
    {
        public CategoryAddValidator()
        {
            RuleFor(I => I.Name).NotEmpty().WithMessage("Ad alanı boş geçilemez");
        }
    }
}
