using BankingApp.Presentation.Areas.Customer.Models;
using HtmlAgilityPack;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Net;
using System.Xml;

namespace BankingApp.Presentation.Areas.Customer.Controllers
{
    [Area("Customer")]
    [Route("Customer/[controller]/[action]")]
    public class CurrencyController : Controller
    {
        public IActionResult Index()
        {
            List<CurrencyViewModel> CurrencyList = new List<CurrencyViewModel>();
            XmlDocument xml = new XmlDocument();
            xml.Load("https://www.tcmb.gov.tr/kurlar/today.xml");

            XmlElement document = xml.DocumentElement;
            XmlNodeList nodes = document.SelectNodes("/Tarih_Date/Currency");

            return View(CurrencyList);
        }
    }
}
