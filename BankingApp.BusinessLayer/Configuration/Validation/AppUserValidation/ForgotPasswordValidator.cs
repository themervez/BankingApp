using BankingApp.DTOLayer.DTOs.AppUserDTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.BusinessLayer.Configuration.Validation.AppUserValidation
{
    public class ForgotPasswordValidator : AbstractValidator<ForgotPasswordDTO>
    {
        public ForgotPasswordValidator()
        {
            RuleFor(x => x.Email).NotEmpty().WithMessage("E-mail alanı boş geçilemez!");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen Geçerli Bir E-mail Adresi Giriniz!").When(x => !string.IsNullOrEmpty(x.Email));
        }
    }
}
