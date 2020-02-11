using OnlineSinavSistemi.Bll.Abstract;
using OnlineSinavSistemi.Core.Concrete;
using OnlineSinavSistemi.Dal.Abstract;
using OnlineSinavSistemi.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace OnlineSinavSistemi.Bll.Concrete
{
    public class YorumService: IYorumService
    {
        IYorumRepository repository;
        public YorumService(IYorumRepository _repository)
        {
            repository = _repository;
        }
        public ResultMessage<Yorum> Add(Yorum data)
        {
            return repository.Add(data);
        }
        public ResultMessage<ICollection<Yorum>> GetAll(Expression<Func<Yorum, bool>> filter = null)
        {
            return repository.GetAll(filter);
        }

        public ResultMessage<Yorum> SoftDelete(int id)
        {
            return repository.SoftDelete(id);
        }

        public ResultMessage<Yorum> Update(Yorum data)
        {
            return repository.Update(data);
        }
    }
}
