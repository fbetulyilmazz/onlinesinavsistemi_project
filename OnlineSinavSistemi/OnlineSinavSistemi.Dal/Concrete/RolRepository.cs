using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineSinavSistemi.Dal.Concrete
{
    public class RolRepository : EFBaseRepository<OnlineSinavSistemiContext, Rol>, IRolRepository
    {
        public RolRepository(OnlineSinavSistemiContext context) : base(context)
        {

        }
        public ICollection<Rol> RolleriGetir()
        {

            
                return context.Rol.Where(x => x.KullaniciRoller == null).ToList();
            
        }
    }

}
