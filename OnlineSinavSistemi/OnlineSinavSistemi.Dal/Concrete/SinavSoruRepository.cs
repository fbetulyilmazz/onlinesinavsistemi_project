using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class SinavSoruRepository : EFBaseRepository<OnlineSinavSistemiContext, SinavSoru>, ISinavSoruRepository
    {
        public SinavSoruRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }
        public ICollection<SinavSoru> SinavinSorularini(int soruId)
        {
            return GetAll(x => x.Id == soruId).Data;
        }

        public ICollection<SinavSoru> SorularinSinavlari(int sinavId)
        {
            return GetAll(x => x.Id == sinavId).Data;
            //using (OnlineSinavSistemiContext context = new OnlineSinavSistemiContext())
            // {
            //     return context.Sinav.Where(x => x.Id == sinavId).ToList();
            //}

        }


    }
}
