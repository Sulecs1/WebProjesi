using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using BlogProjem.DTO.DTOs.CommentDtos;

namespace BlogProjem.Business.ValidationRules.FluentValidation
{
    public class CommentAddValidator : AbstractValidator<CommentAddDto>
    {
        public CommentAddValidator()
        {
            RuleFor(I => I.AuthorName).NotEmpty().WithMessage("Ad alanı boş bırakılamaz");
            RuleFor(I => I.AuthorEmail).NotEmpty().WithMessage("Ad alanı boş bırakılamaz");

            RuleFor(I => I.Description).NotEmpty().WithMessage("Ad alanı boş bırakılamaz");

        }
    }
}
