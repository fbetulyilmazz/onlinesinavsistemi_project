using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;

namespace OnlineSinavSistemi.UI.Controllers
{
    public class YorumController : Controller
    {
        IUnitOfWork service;
        public YorumController(IUnitOfWork _service)
        {
            service = _service;
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Yorum model)
        {
            
            model.KayitTarihi = DateTime.Now;
            model.SilindiMi = false;
            service.Yorum.Add(model);
            var result = service.SaveChanges();
            TempData["Mesaj"] = result.BasariliMi ? "Kayıt Eklendi." : result.Mesaj;
            return View();
        }
    }
}