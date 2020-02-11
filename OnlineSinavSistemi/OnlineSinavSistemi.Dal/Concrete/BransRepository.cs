using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class BransRepository : EFBaseRepository<OnlineSinavSistemiContext, Brans>, IBransRepository
    {
        public BransRepository(OnlineSinavSistemiContext context) :base(context)
        {
        }
        public ICollection<Brans> AnaBranslariGetir()
        {
            
               return context.Brans.Where(x => x.UstBransId == null).ToList();
            
        }
    }
}
