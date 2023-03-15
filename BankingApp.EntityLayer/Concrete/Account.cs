using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.EntityLayer.Concrete
{
    public class Account
    {
        public int ID { get; set; }

        //Account Name
        public string Name { get; set; }
        private decimal _Balance;

        public decimal Balance
        {
            get
            {
                return _Balance;
            }
            set
            {
                // Validate the value before storing it in the _Amount variable
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Balance", "Please Check the Process");
                }
                else
                {
                    _Balance = value;
                }
            }
        }
    }
}
