using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;

namespace OnlineSinavSistemi.UI.Areas.Admin.Controllers
{
    public class SoruController : AdminBaseController
    {
        ISoruService service;
        public SoruController(ISoruService _service)
        {
            service = _service;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SoruGetByKursID(int bransId)
        {
            var sonuc = service.GetAll(x => x.BransId == bransId);
            return View(sonuc);
        }

        [HttpPost]
        public IActionResult Ekle(Soru model)
        {
            model.KayitTarihi = DateTime.Now;
            model.SilindiMi = false;
            service.Add(model);
            return View();
        }

        [HttpPost]
        public IActionResult Guncelle(Soru model)
        {
            model.GuncellemeTarihi = DateTime.Now;
            model.SilindiMi = false;
            service.Update(model);
            return View();
        }

        [HttpPost]
        public IActionResult SoftDelete(int id)
        {

            service.SoftDelete(id);
            return View();
        }
    }
}