using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class SinavRepository : EFBaseRepository<OnlineSinavSistemiContext, Sinav>, ISinavRepository
    {
        public SinavRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }
        List<Sinav> ISinavRepository.KontejyanaBak()
        {
            
                return context.Sinav.Where(x => x.Kontenjan == null).ToList();
            
        }

    }
}
