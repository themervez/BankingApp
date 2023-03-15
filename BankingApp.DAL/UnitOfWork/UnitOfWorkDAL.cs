using BankingApp.DAL.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.DAL.UnitOfWork
{
    public class UnitOfWorkDAL : IUnitOfWorkDAL
    {
        private readonly BankingAppDbContext _context;

        public UnitOfWorkDAL(BankingAppDbContext context)
        {
            _context = context;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

    }
}
