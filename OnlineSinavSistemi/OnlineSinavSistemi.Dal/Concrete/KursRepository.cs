using Microsoft.EntityFrameworkCore;
using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class KursRepository : EFBaseRepository<OnlineSinavSistemiContext, Kurs>, IKursRepository
    {
        public KursRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }

        public ICollection<Kurs> GetCoursesWithExams()
        {
            return context.Kurs.Where(x => x.SilindiMi == false).Include(x => x.Sinav).ToList();
            //return context.Kurs.Where(x => x.SilindiMi == false).Include(x => x.Sinav).Include(x=> x.Sinav.Brans).Include(x=> x.Sinav.Ogretmen).ToList();
        } 

        DateTime IKursRepository.KursunBaslamaTarihiniOgren(int KursId)
        {
           
                return Get(x => x.Id == KursId).Data.BaslamaTarihi;
            
        }
    }
}
