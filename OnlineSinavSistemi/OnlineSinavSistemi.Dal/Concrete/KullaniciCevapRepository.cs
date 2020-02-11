using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class KullaniciCevapRepository : EFBaseRepository<OnlineSinavSistemiContext, KullaniciCevap>, IKullaniciCevapRepository
    {
        public KullaniciCevapRepository(OnlineSinavSistemiContext context) : base(context)
        {
            
        }
        public List<KullaniciCevap> KullaniciCevaplari()
        {
            
                return context.KullaniciCevap.Where(x => x.SoruId == 0).ToList();
            
        }
    }

}
