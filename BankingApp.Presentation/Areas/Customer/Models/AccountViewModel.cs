using System.ComponentModel.DataAnnotations;

namespace BankingApp.Presentation.Areas.Customer.Models
{
    public class AccountViewModel
    {
        [Required(ErrorMessage = "Gönderici ID alanı gereklidir!")]
        public int SenderID { get; set; }

        [Required(ErrorMessage = "Alıcı ID alanı gereklidir!")]
        public int ReceiverID { get; set; }

        [Required(ErrorMessage = "Gönderilecek Tutar alanı gereklidir!")]
        [DataType(DataType.Currency)]
        [Range(0, float.MaxValue, ErrorMessage = "Lütfen pozitif değerde bir tutar giriniz!")]
        public decimal Amount { get; set; }
    }
}
