using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;

namespace OnlineSinavSistemi.UI.Areas.Admin.Controllers
{
    public class KursMerkeziController : AdminBaseController
    {
        IKursMerkeziService service;
        public KursMerkeziController(IKursMerkeziService _service)
        {
            service = _service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ICollection<KursMerkezi> liste = service.GetAll().Data;

            return View(liste);
        }


        [HttpGet]
        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(KursMerkezi model)
        {
            model.KayitTarihi = DateTime.Now;
            model.SilindiMi = false;
            service.Add(model);
            return View();
        }


        [HttpPost]
        public IActionResult Sil(int id)
        {
            service.SoftDelete(id);
            return View();
        }


        [HttpGet]
        public IActionResult Guncelle(int id)
        {
            return View();
        }

        [HttpPost]
        public IActionResult Guncelle(KursMerkezi model)
        {
            //ekleme işlemi ypaulacak.
            service.Update(model);
            return View();
        }



    }
}