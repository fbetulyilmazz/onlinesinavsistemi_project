using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSinavSistemi.UI.ViewComponents
{
    [ViewComponent]
    public class GetLoginNameViewComponent : ViewComponent
    {
        IHttpContextAccessor acc;

        public GetLoginNameViewComponent(IHttpContextAccessor _acc)
        {
            acc = _acc;
        }
        public IViewComponentResult Invoke()
        {
            var user = acc.HttpContext.Session.GetObject<Kullanici>("lgnUser");
            return View(user);
        }
    }
}
