using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using OnlineSinavSistemi.Core.Abstract;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace OnlineSinavSistemi.Core.Concrete
{
    public class EFBaseRepository<TContext, TEntity> : IRepository<TEntity>
          where TEntity : class, IVeri, new()
        where TContext : DbContext, new()
    {
      protected  TContext context;

        public EFBaseRepository(TContext _context)
        {
            context = _context;
        }
        public ResultMessage<TEntity> Add(TEntity data)
        {
            //using (TContext context = new TContext())
            //{
                //using (var dbTransaction = context.Database.BeginTransaction())
                //{

                try
                {
                    var addedData = context.Entry(data);
                    addedData.State = EntityState.Added;
                    //int result = context.SaveChanges();
                    
                    //dbTransaction.Commit();
                     return new ResultMessage<TEntity> { BasariliMi = true, Data = data, Mesaj = "Kayıt eklenmeye hazır." };


                }
                catch (Exception ex)
                {
                    //dbTransaction.Rollback();
                    return new ResultMessage<TEntity> { BasariliMi = false, Data = null, Mesaj = ex.Message };
                }
                //}

            //}
        }

        public ResultMessage<TEntity> Delete(int id)
        {
            try
            {
                //using (TContext context = new TContext())
                //{
                    var data = context.Set<TEntity>().Find(id);
                    var deletedData = context.Entry(data);
                    deletedData.State = EntityState.Deleted;
                    //int result = context.SaveChanges();
                    //ternary if
                    return new ResultMessage<TEntity> { BasariliMi = true, Data = data, Mesaj = "Kayıt silinmeye hazır." };
                //}
            }
            catch (Exception ex)
            {
                return new ResultMessage<TEntity> { BasariliMi = false, Data = null, Mesaj = ex.Message };
            }
        }

        public ResultMessage<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                using (TContext context = new TContext())
                {
                  TEntity data =  context.Set<TEntity>().Where(filter).FirstOrDefault();
                    //TEntity data =  context.Set<TEntity>().FirstOrDefault(filter);
                    //ternary if
                    return data==null ? new ResultMessage<TEntity> { BasariliMi=false, Mesaj="Aranan kriterlere uygun kayıt bulunamadı." } :  new ResultMessage<TEntity> { BasariliMi = true, Mesaj = "Kayıt getirildi.", Data=data };
                }
            }
            catch (Exception ex)
            {
                return new ResultMessage<TEntity> { BasariliMi = false, Mesaj = ex.Message };
            }
        }

        public ResultMessage<ICollection<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {

            try
            {
                using (TContext context = new TContext())
                {
                    ICollection<TEntity> dataList;
                    if (filter == null)
                    {
                        dataList = context.Set<TEntity>().ToList();
                    }
                    else
                    {
                        dataList = context.Set<TEntity>().Where(filter).ToList();
                    }
                    return new ResultMessage<ICollection<TEntity>> { BasariliMi = true, Data = dataList, Mesaj = "Veriler listelendi." };
                }
            }
            catch (Exception ex)
            {
                return new ResultMessage<ICollection<TEntity>> { BasariliMi = false, Mesaj = ex.Message };
            }
            

        }

        public ResultMessage<TEntity> SoftDelete(int id)
        {
            try
            {
                //using (TContext context = new TContext())
                //{
                    var data = context.Set<TEntity>().Find(id);
                    var softDeletedData = context.Entry(data);
                    data.SilindiMi = true;
                    softDeletedData.State = EntityState.Modified;
                    //int result = context.SaveChanges();
                   
                    return new ResultMessage<TEntity> { BasariliMi = true, Data = data, Mesaj = "Kayıt silinmeye hazır." };
                //}
            }
            catch (Exception ex)
            {
                return new ResultMessage<TEntity> { BasariliMi = false, Data = null, Mesaj = ex.Message };
            }
        }

        public ResultMessage<TEntity> Update(TEntity data)
        {

            try
            {
                //    using (TContext context = new TContext())
                //    { model.GuncellemeTarihi = DateTime.Now;
          
                var updatedData = context.Entry(data);
                    updatedData.State = EntityState.Modified;
                    //int result = context.SaveChanges();
                    //ternary if
                    return   new ResultMessage<TEntity> { BasariliMi = true, Data = data, Mesaj = "Kayıt güncellenmeye hazır." };
                //}
            }
            catch (Exception ex)
            {
                return new ResultMessage<TEntity> { BasariliMi = false, Data = null, Mesaj = ex.Message };
            }
        }
    }
}
