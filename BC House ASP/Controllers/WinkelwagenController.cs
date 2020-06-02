using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BC_House_ASP.Controllers
{
    public class WinkelwagenController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}