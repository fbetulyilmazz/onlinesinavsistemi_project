using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class KullaniciRepository : EFBaseRepository<OnlineSinavSistemiContext, Kullanici>, IKullaniciRepository
    {
        public KullaniciRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }
        public List<Kullanici> KullaniciMailListesi()
        {
                return context.Kullanici.Where(x => x.EMail == null).ToList();

        }


    }
}
