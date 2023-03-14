using BankingApp.DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.BusinessLayer.Configuration.Validation.AppUserValidation
{
    public class ResetPasswordValidator : AbstractValidator<ResetPasswordDTO>
    {
        public ResetPasswordValidator()
        {
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş geçilemez!");
            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre Onay alanı boş geçilemez!");
            RuleFor(x => x.Password).Equal(y => y.ConfirmPassword).WithMessage("Şifreler birbiriyle uyuşmuyor!");
        }
    }
}
