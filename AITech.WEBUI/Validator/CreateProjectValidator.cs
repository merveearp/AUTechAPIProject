using AITech.WEBUI.DTOs.ProjectDtos;
using FluentValidation;

namespace AITech.WEBUI.Validator
{
    public class CreateProjectValidator:AbstractValidator<CreateProjectDto>

    {
        public CreateProjectValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Başlık alanı boş bırakılamaz")
                .MinimumLength(3).WithMessage("Başlık en az 3 karakterden oluşmalıdır");
            RuleFor(x => x.ImageUrl).NotEmpty().WithMessage("Resim alanı boş bırakılamaz");
            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori alanı boş bırakılamaz");
        }

    }
}
