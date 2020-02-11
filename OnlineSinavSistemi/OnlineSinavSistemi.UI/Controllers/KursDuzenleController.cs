using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace OnlineSinavUI.Controllers
{
    public class KursDuzenleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult KursDuzenle()
        {
            return View();
        }
        public IActionResult Siniflarim()
        {
            return View();
        }

        public IActionResult Ogrencilerim()
        {
            return View();
        }

        public IActionResult SinavOlustur()
        {
            return View();
        }
    }
}