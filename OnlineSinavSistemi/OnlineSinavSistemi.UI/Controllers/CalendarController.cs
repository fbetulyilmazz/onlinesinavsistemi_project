﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineSinavUI.Controllers
{
    public class CalendarController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}