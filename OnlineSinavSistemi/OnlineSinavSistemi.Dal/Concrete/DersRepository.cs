using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class DersRepository : EFBaseRepository<OnlineSinavSistemiContext, Ders>, IDersRepository

    {

        public DersRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }
        public ICollection<Ders> DersleriGetir()
        {
            
                return context.Ders.Where(x => x.KullanicininDersleri == null).ToList();
           
        }
    }


}
