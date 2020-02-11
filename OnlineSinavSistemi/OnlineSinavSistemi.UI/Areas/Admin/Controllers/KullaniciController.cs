using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSinavSistemi.UI.Areas.Admin.Controllers
{
    public class KullaniciController : AdminBaseController
    {
        IKullaniciService kullaniciService;
        public KullaniciController(IKullaniciService _kullaniciService)
        {
            kullaniciService = _kullaniciService;
        }

        [HttpGet]
        public IActionResult Listele()
        {
            kullaniciService.GetAll();
            return View(kullaniciService);
        }
        [HttpGet]
        public IActionResult Ekle()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Ekle(Kullanici model)
        {
            model.KayitTarihi = DateTime.Now;
            model.SilindiMi = false;
            TempData["mesaj"] = kullaniciService.Add(model);
            return RedirectToAction("Listele");
        }
        [HttpGet]
        public IActionResult Sil(Kullanici model)
        {
            model.SilindiMi = true;
            TempData["mesaj"] = kullaniciService.SoftDelete(model.Id);
            return RedirectToAction("Listele");
        }
        [HttpGet]
        public IActionResult Guncelle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Guncelle(Kullanici model)
        {
            model.KayitTarihi = DateTime.Now;

            TempData["mesaj"] = kullaniciService.Update(model);
            return RedirectToAction("Listele");
        }
        [HttpGet]
        public IActionResult Detay(int KullaniciId)
        {
            var mesaj = kullaniciService.GetAll(x => x.Id == KullaniciId);
            return View(mesaj);
        }
    }
}
