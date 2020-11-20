using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMSMvc.Controllers
{
    public class WchuoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CeshiAdd()
        {
            return View();
        }
        public IActionResult Add()
        {
            return View();
        }
        public IActionResult Daily()
        {
            return View();
        }
    }
}
