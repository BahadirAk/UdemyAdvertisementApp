using FluentValidation;
using Microsoft.AspNetCore.Rewrite;
using System;
using Udemy.AdvertisementApp.UI.Models;

namespace Udemy.AdvertisementApp.UI.ValidationRules
{
    public class UserCreateModelValidator : AbstractValidator<UserCreateModel>
    {
        public UserCreateModelValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Parola boş olamaz!!!");
            RuleFor(x => x.Password).MinimumLength(3).WithMessage("Parola minumum 3 karakterli olmalıdır!!!");
            RuleFor(x => x.Password).Equal(x => x.ConfirmPassword).WithMessage("Parola eşleşmiyor!!!");
            RuleFor(x => x.Firstname).NotEmpty().WithMessage("Ad boş olamaz!!!");
            RuleFor(x => x.Surname).NotEmpty().WithMessage("Soyad boş olamaz!!!");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı boş olamaz!!!");
            RuleFor(x => x.Username).MinimumLength(3).WithMessage("Kullanıcı adı minumum 3 karakterli olmalıdır!!!");
            RuleFor(x => new
            {
                x.Username,
                x.Firstname
            }).Must(x => CanNotFirstname(x.Username, x.Firstname)).WithMessage("Kullanıcı adı, adınızı içeremez!!!").When(x => x.Username != null && x.Firstname != null);
            RuleFor(x => x.GenderId).NotEmpty().WithMessage("Cinsiyet seçimi zorunludur!!!");
        }

        private bool CanNotFirstname(string username, string firstname)
        {
            return !username.Contains(firstname);
        }
    }
}
