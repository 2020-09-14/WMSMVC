﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WMSMvc.Controllers
{
    public class PurchaseController :Controller
    {
        public ActionResult Show()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View();
        }
    }
}
