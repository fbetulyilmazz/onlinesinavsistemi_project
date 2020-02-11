using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class KullaniciSinavRepository : EFBaseRepository<OnlineSinavSistemiContext, KullaniciSinav>, IKullaniciSinavRepository
    {
        public KullaniciSinavRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }
        public ICollection<KullaniciSinav> KullaniciSinavlariGetir(int id)
        {
           
                return context.KullaniciSinav.Where(x => x.SinavId == id).ToList();
           
        }
    }
}
