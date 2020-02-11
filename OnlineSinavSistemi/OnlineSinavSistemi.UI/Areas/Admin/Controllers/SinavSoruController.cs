using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;

namespace OnlineSinavSistemi.UI.Areas.Admin.Controllers
{
    public class SınavSoruController : AdminBaseController
    {
        ISinavSoruService sinavSoruService;

        public SınavSoruController(ISinavSoruService _sinavSoruService)
        {
            sinavSoruService = _sinavSoruService;

        }

        [HttpGet]
        public ActionResult Ekle()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Ekle(SinavSoru model)
        {
            SinavSoru sinav = new SinavSoru();
            sinav.Id = model.Id;
            sinav.SinavId = model.SinavId;
            sinav.Soru = model.Soru;
            sinav.SoruId = model.SoruId;

            model.KayitTarihi = DateTime.Now;
            model.SilindiMi = false;



            sinavSoruService.Add(model);
            return View();

        }

    }
}