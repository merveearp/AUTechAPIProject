using AITech.WEBUI.DTOs.UserDtos;
using FluentValidation;

namespace AITech.WEBUI.Validator
{
    public class RegisterUserValidator :AbstractValidator<RegisterUserDto>
    {
        public RegisterUserValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("Ad alanı boş bırakılamaz");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Soyad alanı boş bırakılamaz");
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı Adı alanı boş bırakılamaz");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email alanı boş bırakılamaz");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Geçerli Email Adresi giriniz");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş bırakılamaz");
            RuleFor(x => x.ConfirmPassword).Equal(x => x.Password).WithMessage("Şifreler birbiriyle uyuşmuyor");

        }
    }
}
