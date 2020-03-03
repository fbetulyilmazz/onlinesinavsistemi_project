using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.Extensions.Caching.Distributed;
using Newtonsoft.Json;
using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Model.Data;
using OnlineSinavSistemi.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineSinavSistemi.UI.ViewComponents
{
    [ViewComponent]
    public class BransListesiViewComponent :ViewComponent
    {
        IUnitOfWork service;
        IDistributedCache cache;
        public BransListesiViewComponent(IUnitOfWork _service, IDistributedCache _cache)
        {
            service = _service;
            cache = _cache;
        }
        //public ViewViewComponentResult Invoke()
        public IViewComponentResult Invoke()
        {
            ICollection<Brans> branslar;
            var kursList = service.Kurs.GetCoursesWithExams().ToList();
          string cachedData =  cache.GetString("branslar2");
            if (String.IsNullOrEmpty(cachedData))
            {
                branslar = service.Brans.GetAll().Data.ToList();
                cache.SetString("branslar1", JsonConvert.SerializeObject(branslar), new DistributedCacheEntryOptions { AbsoluteExpiration= Convert.ToDateTime("01.12.2020") });
                //şu zamana kadar cache tutulacak.
                cache.SetString("branslar2", JsonConvert.SerializeObject(branslar), new DistributedCacheEntryOptions { AbsoluteExpirationRelativeToNow = new TimeSpan(0,0,10 )});
                //şu andan itibaren 5 dk boyunca cache tutulacak.
                cache.SetString("branslar3", JsonConvert.SerializeObject(branslar), new DistributedCacheEntryOptions { SlidingExpiration = new TimeSpan(0, 0, 15) });
                //son kullanıldığı andan itibaren 5 dk boyunca cache tutulacak.
            }
            else
            {
                branslar = JsonConvert.DeserializeObject<List<Brans>>(cachedData);
            }
            //return View("BransListesiPartial",new KursBransViewModel { KursListesi = kursList, BransListesi = bransList });
            return View(new KursBransViewModel { KursListesi = kursList, BransListesi = branslar.ToList() });
        }
    }
}
