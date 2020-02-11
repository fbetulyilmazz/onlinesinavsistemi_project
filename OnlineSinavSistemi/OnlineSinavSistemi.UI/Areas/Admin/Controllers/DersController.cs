using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;

namespace OnlineSinavSistemi.UI.Areas.Admin.Controllers
{
    public class DersController : AdminBaseController
    {
        IUnitOfWork service;
        public DersController(IUnitOfWork _service)
        {
            service = _service;
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}

        [HttpGet]
        public IActionResult DersGetByKursID(int kursId)
        {
            var sonuc = service.Ders.GetAll(x => x.KursId == kursId).Data;
            return View(sonuc);
        }

        public IActionResult Listele()
        {
            var sonuc = service.Ders.GetAll(x => x.SilindiMi == false).Data;
            return View(sonuc);
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Ekle(Ders model)
        {
            model.KayitTarihi = DateTime.Now;
            model.SilindiMi = false;
            service.Ders.Add(model);
            var sonuc = service.SaveChanges();
            return RedirectToAction(nameof(Ekle));
        }

        [HttpPost]
        public IActionResult Guncelle(Ders model)
        {
            model.GuncellemeTarihi = DateTime.Now;
            model.SilindiMi = false;
            service.Ders.Update(model);
            var sonuc = service.SaveChanges();
            return RedirectToAction(nameof(Listele));
        }

        [HttpPost]
        public IActionResult SoftDelete(int id)
        {
            service.Ders.SoftDelete(id);
            var sonuc = service.SaveChanges();
            return RedirectToAction(nameof(Listele));
        }
    }

}