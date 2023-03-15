using BankingApp.DAL.Abstract;
using BankingApp.DAL.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.DAL.Repository
{
    public class GenericUowRepository<T> : IGenericUowDAL<T> where T : class
    {
        private BankingAppDbContext _context;
        public GenericUowRepository(BankingAppDbContext context)
        {
            _context = context;
        }
        public void Delete(T t)
        {
            _context.Remove(t);
        }

        public T GetByID(int id)
        {
            return _context.Set<T>().Find(id);
        }

        public List<T> GetList()
        {
            return _context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            _context.Add(t);
        }

        public void MultiUpdate(List<T> t)
        {
            _context.UpdateRange(t);//Listeden gelen değerin tamamını güncelledik
        }

        public void Update(T t)
        {
            _context.Update(t);
        }
    }
}
