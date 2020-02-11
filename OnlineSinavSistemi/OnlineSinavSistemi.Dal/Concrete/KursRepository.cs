using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class KursRepository : EFBaseRepository<OnlineSinavSistemiContext, Kurs>, IKursRepository
    {
        public KursRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }

        DateTime IKursRepository.KursunBaslamaTarihiniOgren(int KursId)
        {
           
                return Get(x => x.Id == KursId).Data.BaslamaTarihi;
            
        }
    }
}
