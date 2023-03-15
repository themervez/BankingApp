namespace BankingApp.Presentation.Areas.Customer.Models
{
    public class CurrencyViewModel
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal PriceBuy { get; set; }
        public decimal PriceSell { get; set; }
    }
}
