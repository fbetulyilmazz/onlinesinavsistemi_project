﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;

namespace OnlineSinavSistemi.UI.Areas.Admin.Controllers
{
    public class YorumController : Controller
    {
        IUnitOfWork service;
        public YorumController(IUnitOfWork _service)
        {
            service = _service;
        }

        [HttpGet]
        public IActionResult Listeleme()
        {
            var list = service.Yorum.GetAll();
            return View(list);
        }
        [HttpGet]
        public IActionResult Silme()
        {
            
            return View();

        }

        [HttpPost]
        public IActionResult Silme(int id)
        {
            service.Yorum.SoftDelete(id);
            return View();

        }
    }
}