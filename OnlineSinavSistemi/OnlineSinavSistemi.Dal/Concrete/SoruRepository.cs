using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class SoruRepository : EFBaseRepository<OnlineSinavSistemiContext, Soru> , ISoruRepository
    {
        public SoruRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }
        public ICollection<Soru> BransSorulari(int bransSorulari)
        {
           
                return context.Soru.Where(x => x.BransId == bransSorulari).ToList();
                }
    }
}
