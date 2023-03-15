using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.EntityLayer.Concrete
{
    public class ProcessDetail
    {
        public int ID { get; set; }
        public string ReceiverName { get; set; }
        public string SenderName { get; set; }

        [Range(0, float.MaxValue, ErrorMessage = "Please enter positive Amount")]
        public decimal Amount { get; set; }
        public DateTime ProcessDate { get; set; }
    }
}
