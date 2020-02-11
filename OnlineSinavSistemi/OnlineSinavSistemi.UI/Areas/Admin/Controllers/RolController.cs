using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;

namespace OnlineSinavSistemi.UI.Areas.Admin.Controllers
{
    public class RolController : AdminBaseController

    {
        IRolService service;
        public RolController(IRolService _Rolservice)
        {
            service = _Rolservice;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ekle(Rol model)
        {
            return View();
        }
        [HttpPost]
        public IActionResult update(Rol model)
        {
            return View();
        }
        [HttpPost]
        public IActionResult delete(int id)
        {
            return View();
        }

    }
}