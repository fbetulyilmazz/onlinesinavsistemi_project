using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class YorumRepository : EFBaseRepository<OnlineSinavSistemiContext, Yorum>, IYorumRepository
    {
        public YorumRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }
        public List<Yorum> IciBosYorumlar()
        {

            return context.Yorum.Where(x => x.Aciklama == null).ToList();

        }
    }
}
