using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;

namespace OnlineSinavSistemi.UI.Areas.Admin.Controllers
{
    public class YorumController : Controller
    {
        IYorumService service;
        public YorumController(IYorumService _service)
        {
            service = _service;
        }

        [HttpGet]
        public IActionResult Listeleme()
        {
            var list = service.GetAll();
            return View(list);
        }
        [HttpPost]
        public IActionResult Silme(int id)
        {
            service.SoftDelete(id);
            return View();

        }
    }
}