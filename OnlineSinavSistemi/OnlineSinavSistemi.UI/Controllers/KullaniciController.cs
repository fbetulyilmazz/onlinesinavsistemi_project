using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;
using OnlineSinavSistemi.UI.Models;

namespace OnlineSinavSistemi.UI.Controllers
{
    public class KullaniciController : Controller
    {
        IUnitOfWork service;
        public KullaniciController(IUnitOfWork _service)
        {
            service = _service;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            var user = service.Kullanici.Login(model.EMail, model.Sifre);
            if (user.Data != null)
            {
                //Session["LoginUser"] = user;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        public IActionResult Logout()
        {
            //Session["LoginUser"] = null;
            //Session.Remove("LoginUser");
            return RedirectToAction("Login", "Kullanici");
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            service.Kullanici.Add(new Kullanici { Ad = model.Ad, Soyad = model.Soyad, Tc = model.Tc, DogumTarihi = model.DogumTarihi, EMail = model.EMail, Sifre = model.Sifre, FotoUrl = model.FotoURL, KayitTarihi = DateTime.Now, SilindiMi = false });
            var sonuc = service.SaveChanges();
            //var userId = service.Kullanici.GetAll(x => x.EMail == model.EMail).Data.FirstOrDefault().Id;
            return RedirectToAction(nameof(Login));
        }
    }
}