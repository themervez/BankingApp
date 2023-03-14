using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp.DTOLayer.DTOs.AppUserDTOs
{
    public class ResetPasswordDTO
    {
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
