﻿using BankingApp.DAL.Abstract;
using BankingApp.DAL.DbContexts;
using BankingApp.DAL.Repository;
using BankingApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.DAL.EF
{
    public class EFProcessDAL : GenericRepository<Process>, IProcessDAL
    {
        public EFProcessDAL(BankingAppDbContext context) : base(context)
        {
        }
    }
}
