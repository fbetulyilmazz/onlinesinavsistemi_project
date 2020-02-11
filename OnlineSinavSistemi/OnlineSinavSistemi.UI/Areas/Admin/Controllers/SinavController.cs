using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;

namespace OnlineSinavSistemi.UI.Areas.Admin.Controllers
{
    public class SinavController : AdminBaseController
    {
        ISinavService service;
        public SinavController(ISinavService _sinav)
        {
            service = _sinav;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View(service.GetAll().Data);
        }
        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Sinav prm)
        {
            Sinav sinav = new Sinav();

            sinav.KursMerkeziId = prm.KursMerkeziId;
            sinav.SinavTarihi = prm.SinavTarihi;
            sinav.SinavSaati = prm.SinavSaati;
            sinav.Suresi = prm.Suresi;
            sinav.SoruSayisi = prm.SoruSayisi;
            sinav.Sinif = prm.Sinif;
            sinav.BransId = prm.BransId;
            sinav.OgretmenId = prm.OgretmenId;
            sinav.KaydedenKullaniciId = prm.KaydedenKullaniciId;
            sinav.Kontenjan = prm.Kontenjan;
            sinav.OturumBittiMi = false;
            sinav.SilindiMi = false;
            sinav.KayitTarihi = DateTime.Now;
            service.Add(sinav);
            TempData["Message"] = "Başarıyla Eklediniz";
            return RedirectToAction("Index");
        }

        public IActionResult SinavGetbyID(int ID)
        {
            var sonuc = service.GetAll(x => x.Id == ID);
            return View(sonuc);
        }

        [HttpGet]
        public IActionResult SoftDelete(int ID)
        {
            var sonuc = service.GetAll(x => x.Id == ID);
            return View(sonuc);
        }
        [HttpPost]
        public IActionResult SoftDelete(Sinav data)
        {
            service.SoftDelete(data.Id);    
            return View();
        }


    }
}