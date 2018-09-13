using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCStore.Models;

namespace MVCStore.Controllers
{
    public class AccountsController : Controller
    {
        public ActionResult Index()
        {
            var accounts = Account.GetAccounts();

            return View(accounts);
        }
    }
}