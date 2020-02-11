using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class KursDersRepository : EFBaseRepository<OnlineSinavSistemiContext, KursDers>, IKursDersRepository
    {
        public KursDersRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }
        public ICollection<Ders> KursunDersleriniGetir(int id)
        {
         
                return context.Ders.Where(x => x.KursId == id).ToList();
            
        }

        public ICollection<Kullanici> KursunKullanicilariniGetir(int id)
        {
            
                return context.KullaniciKurs.Where(x => x.KursId == id).Select(x => x.Kullanici).ToList();
            
        }
    }
}
