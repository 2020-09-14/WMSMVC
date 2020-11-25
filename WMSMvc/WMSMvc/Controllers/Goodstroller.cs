using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMSMvc.Controllers
{
    public class Goodstroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
