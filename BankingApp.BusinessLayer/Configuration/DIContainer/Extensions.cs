﻿using BankingApp.BusinessLayer.Configuration.Validation.AppUserValidation;
using BankingApp.BusinessLayer.Configuration.Validation.CustomerValidation;
using BankingApp.BusinessLayer.Configuration.Validation.ProcessValidation;
using BankingApp.BusinessLayer.Features.Abstract;
using BankingApp.BusinessLayer.Features.Abstract.UowAbstract;
using BankingApp.BusinessLayer.Features.Concrete;
using BankingApp.BusinessLayer.Features.Concrete.UowConcrete;
using BankingApp.DAL.Abstract;
using BankingApp.DAL.EF;
using BankingApp.DAL.UnitOfWork;
using BankingApp.DTOLayer.DTOs.AppUserDTOs;
using BankingApp.DTOLayer.DTOs.CustomerDTOs;
using BankingApp.EntityLayer.Concrete;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.BusinessLayer.Configuration.DIContainer
{
    public static class Extensions
    {
        public static void ContainerDependencies(this IServiceCollection services)
        {
            //Her requestte yenilenmesi için AddScoped tercih edildi
            services.AddScoped<IProcessService, ProcessService>();
            services.AddScoped<IProcessDAL, EFProcessDAL>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IAccountDAL, EFAccountDAL>();
            services.AddScoped<IAccountService, AccountService>();

            services.AddScoped<IProcessDetailDAL, EFProcessDetailDAL>();
            services.AddScoped<IProcessDetailService, ProcessDetailService>();
            services.AddScoped<IUnitOfWorkDAL, UnitOfWorkDAL>();
        }
        public static void CustomizeValidator(this IServiceCollection services)
        {
            services.AddTransient<IValidator<SignInDTO>, SignInValidator>();
            services.AddTransient<IValidator<SignUpDTO>, SignUpValidator>();
            services.AddTransient<IValidator<ForgotPasswordDTO>, ForgotPasswordValidator>();
            services.AddTransient<IValidator<ResetPasswordDTO>, ResetPasswordValidator>();
            services.AddTransient<IValidator<ProfileUpdateDTO>, ProfileUpdateValidator>();
            services.AddTransient<IValidator<Process>, ProcessValidator>();
            services.AddTransient<IValidator<AppUser>, AppUserValidator>();//
        }
    }
}
