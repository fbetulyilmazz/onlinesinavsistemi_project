using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class KursMerkeziRepository : EFBaseRepository<OnlineSinavSistemiContext, KursMerkezi>, IKursMerkeziRepository
    {
        public KursMerkeziRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }
        public ICollection<KursMerkezi> IlceSec(string ilce)
        {
           
                return context.KursMerkezi.Where(x => x.Ilce == ilce).ToList();

        }

        public ICollection<KursMerkezi> IlSec(string il)
        {
            
                return context.KursMerkezi.Where(x => x.Il == il).ToList();


        }
    }
}
