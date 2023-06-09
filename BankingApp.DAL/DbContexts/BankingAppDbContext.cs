﻿using BankingApp.EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.DAL.DbContexts
{
    public class BankingAppDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        private IConfiguration _configuration;
        public BankingAppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<ProcessDetail> ProcessDetails { get; set; }
        //public DbSet<Customer> Customers { get; set; }
        //public DbSet<Employee> Employees { get; set; }
        public DbSet<Process> Processes { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("ConStr");//From appsettings.json file
            base.OnConfiguring(optionsBuilder.UseSqlServer(connectionString));
        }
    }
}
