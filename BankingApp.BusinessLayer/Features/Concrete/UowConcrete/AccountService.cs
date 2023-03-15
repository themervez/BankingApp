using BankingApp.BusinessLayer.Features.Abstract.UowAbstract;
using BankingApp.DAL.Abstract;
using BankingApp.DAL.UnitOfWork;
using BankingApp.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.BusinessLayer.Features.Concrete.UowConcrete
{
    public class AccountService : IAccountService
    {
        private readonly IAccountDAL _accountDAL;
        private readonly IUnitOfWorkDAL _unitOfWorkDAL;

        public AccountService(IAccountDAL accountDAL, IUnitOfWorkDAL unitOfWorkDAL)
        {
            _accountDAL = accountDAL;
            _unitOfWorkDAL = unitOfWorkDAL;
        }

        public void TInsert(Account t)
        {
            _accountDAL.Insert(t);
            _unitOfWorkDAL.Save();
        }

        public void TMultiUpdate(List<Account> t)
        {
            _accountDAL.MultiUpdate(t);
            _unitOfWorkDAL.Save();
        }

        public void TUpdate(Account t)
        {
            _accountDAL.Update(t);
            _unitOfWorkDAL.Save();
        }
        public void TDelete(Account t)
        {
            _accountDAL.Delete(t);
            _unitOfWorkDAL.Save();
        }
        public Account TGetByID(int id)
        {
            return _accountDAL.GetByID(id);
        }

        public List<Account> TGetList()
        {
            return _accountDAL.GetList();
        }
    }
}
