﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WMSMvc.Controllers
{
    public class AllotController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AllotShow()
        {
            return View();
        }
        public IActionResult ItemdetailShow()
        {
            return View();
        }
        public IActionResult Details()
        {
            return View();
        }
        public IActionResult AuditShow()
        {
            return View();
        }
        public IActionResult LookShow()
        {
            return View();
        }
    }
}