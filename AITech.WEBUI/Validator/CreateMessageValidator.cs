using AITech.WEBUI.DTOs.UserMessageDtos;
using FluentValidation;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;

namespace AITech.WEBUI.Validator
{
    public class CreateMessageValidator :AbstractValidator<CreateUserMessageDto>
    {
        public CreateMessageValidator()
        {
            RuleFor(x => x.FullName).NotEmpty().WithMessage("İsim ve Soyisim Alanı boş bırakılamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email Alanı boş bırakılamaz");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli email adres bilgisi boş girilmelidir");
            RuleFor(x => x.Message).NotEmpty().WithMessage("Mesaj Alanı boş bırakılamaz");
            RuleFor(x => x.Phone).NotEmpty().WithMessage("Telefon Numarası Alanı boş bırakılamaz");
        }
    }
}
