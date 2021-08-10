﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authorization.Orders.Api.Controllers
{
    public class SiteController : Controller
    {
        public IActionResult Index()
        {
            return View();

        }
        public string GetSecrets()
        {
            return "Secret string from Orders Api";
        }
    }
}
