using Dto_s.Dto_s.AppUserDtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.AppUser
{
	public class AppUserRegisterValidator:AbstractValidator<AppUserRegisterDto>
	{
        public AppUserRegisterValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad Alanı Boş Geçilemez");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad Alanı Boş Geçilemez");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı Adı Alanı Boş Geçilemez");
            RuleFor(x => x.Email).NotEmpty().WithMessage("Emai Alanı Boş Geçilemez");
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre Alanı Boş Geçilemez");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Tekrar Alanı Boş Geçilemez");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Ad Alanı Maksimum 30 Karakter Olabilir");
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Ad Alanı Minimum 3 Karakter Olabilir");
            RuleFor(x => x.ConfirmPassword).Equal(y=>y.Password).WithMessage("Parolalarınız Eşleşmiyor");
            RuleFor(x => x.Email).EmailAddress().WithMessage("LÜtfen Geçerli Bir Email Adresi Giriniz");
        }
    }
}
