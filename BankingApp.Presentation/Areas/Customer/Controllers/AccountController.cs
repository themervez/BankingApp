using BankingApp.BusinessLayer.Features.Abstract.UowAbstract;
using BankingApp.EntityLayer.Concrete;
using BankingApp.Presentation.Areas.Customer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BankingApp.Presentation.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Route("Customer/[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MoneyTransfer()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MoneyTransfer(AccountViewModel p)
        {
            var value1 = _accountService.TGetByID(p.SenderID);
            var value2 = _accountService.TGetByID(p.ReceiverID);
            value1.Balance -= p.Amount;
            value2.Balance += p.Amount;

            List<Account> modifiedAccounts = new List<Account>()
            {
                value1,
                value2
            };

            _accountService.TMultiUpdate(modifiedAccounts);

            return View();
        }
    }
}
