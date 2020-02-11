using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;

namespace OnlineSinavSistemi.UI.Areas.Admin.Controllers
{
    public class BransController : AdminBaseController
    {
        //IBransService service;
        //public BransController(IBransService _service)
        //{
        //    service = _service;
        //}

        IUnitOfWork service;
        public BransController(IUnitOfWork _service)
        {
            service = _service;
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Brans model)
        {
            //ekleme işlemi ypaulacak.
            model.KayitTarihi = DateTime.Now;
            model.SilindiMi = false;
            service.Brans.Add(model);
          var result=  service.SaveChanges();
            TempData["Mesaj"] =result.BasariliMi ?  "Kayıt Eklendi." : result.Mesaj;
            return View();
        }
    }
}