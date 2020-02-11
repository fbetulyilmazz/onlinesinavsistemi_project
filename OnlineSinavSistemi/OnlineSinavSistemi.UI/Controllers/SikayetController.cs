using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;

namespace OnlineSinavSistemi.UI.Controllers
{
    public class SikayetController : Controller
    {
        IUnitOfWork service;
        public SikayetController(IUnitOfWork _service)
        {
            service = _service;
        }

        public IActionResult Listele(int kullaniciId)
        {
            ICollection<Sikayet> liste = service.Sikayet.GetAll(x => x.SilindiMi == false && x.Id == kullaniciId).Data;
            return View(liste);
        }
        public IActionResult Ekle(int kullaniciId)
        {

            //ViewBag.Kullanicilar = service.Kullanici.GetByKullaniciId(kullaniciId).Data;
            ViewBag.KursDersler = service.KursDers.GetAll(x => x.KullaniciId == kullaniciId).Data;
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Sikayet model)
        {

            model.KayitTarihi = DateTime.Now;
            model.SilindiMi = false;
            service.Sikayet.Add(model);
            var sonuc = service.SaveChanges();
            TempData["mesaj"] = sonuc.BasariliMi ? "Kayıt Eklendi." : sonuc.Mesaj;
            return RedirectToAction(nameof(Listele));


        }

    }
}