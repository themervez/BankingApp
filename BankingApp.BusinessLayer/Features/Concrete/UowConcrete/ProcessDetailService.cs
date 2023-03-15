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
    public class ProcessDetailService : IProcessDetailService
    {
        private readonly IProcessDetailDAL _processDetailDAL;
        private readonly IUnitOfWorkDAL _unitOfWorkDAL;

        public ProcessDetailService(IProcessDetailDAL processDetailDAL, IUnitOfWorkDAL unitOfWorkDAL)
        {
            _processDetailDAL = processDetailDAL;
            _unitOfWorkDAL = unitOfWorkDAL;
        }

        public void TInsert(ProcessDetail t)
        {
            _processDetailDAL.Insert(t);
            _unitOfWorkDAL.Save();
        }

        public void TMultiUpdate(List<ProcessDetail> t)
        {
            _processDetailDAL.MultiUpdate(t);
            _unitOfWorkDAL.Save();
        }

        public void TUpdate(ProcessDetail t)
        {
            _processDetailDAL.Update(t);
            _unitOfWorkDAL.Save();
        }
        public void TDelete(ProcessDetail t)
        {
            _processDetailDAL.Delete(t);
            _unitOfWorkDAL.Save();
        }
        public List<ProcessDetail> TGetList()
        {
            return _processDetailDAL.GetList();
        }

        public ProcessDetail TGetByID(int id)
        {
            return _processDetailDAL.GetByID(id);
        }
    }
}
