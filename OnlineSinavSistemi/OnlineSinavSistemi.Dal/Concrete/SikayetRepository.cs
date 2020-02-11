using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class SikayetRepository : EFBaseRepository<OnlineSinavSistemiContext, Sikayet>, ISikayetRepository
    {
        public SikayetRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }
        public ICollection<Sikayet> DersinSikayetleriniGetir(int dersid, int kullaniciid)
        {
           
                return context.Sikayet.Where(x => x.KullaniciId == kullaniciid).Where(d => d.DersId == dersid).ToList();
           
        }

        public ICollection<Sikayet> SikayetleriGetir(int kullaniciid)
        {
           
                return context.Sikayet.Where(x => x.KullaniciId == kullaniciid).ToList();
           
        }


    }
}
