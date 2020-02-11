using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;

namespace OnlineSinavSistemi.UI.Areas.Admin.Controllers
{
    public class KursDersController : AdminBaseController
    {
        IKursDersService service;
        public KursDersController(IKursDersService _service)
        {
            service = _service;
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(KursDers model)
        {
            model.KayitTarihi = DateTime.Now;
            model.GuncellemeTarihi = DateTime.Now;
            model.SilindiMi = false;
            service.Add(model);
            return View();
        }
        [HttpGet]
        public IActionResult Guncelle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guncelle(KursDers model)
        {
            model.GuncellemeTarihi = DateTime.Now;
            model.SilindiMi = false;
            service.Update(model);
            return View();
        }
        [HttpGet]
        public IActionResult Sil()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Sil(int id)
        {

            service.SoftDelete(id);
            return View();
        }

        public IActionResult Listele()
        {
            ICollection<KursDers> liste = service.GetAll(x => x.SilindiMi == false).Data;
            return View(liste);
        }

    }


}