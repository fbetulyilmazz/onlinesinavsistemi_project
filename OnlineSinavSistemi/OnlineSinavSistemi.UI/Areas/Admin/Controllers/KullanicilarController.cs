﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineSinavUI.Areas.Admin.Controllers
{
    public class KullanicilarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}