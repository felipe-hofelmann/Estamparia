using Estamparia.Aplication.Interfaces.IRepositorys.IBaseRepositorys;
using Estamparia.Aplication.Models.BaseModels;
using System;
using System.Collections.Generic;


namespace Estamparia.Domain.Repository.BaseRepositorys
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : BaseModel
    {
        public void Create(T model)
        {
            //using (var context = new EstampContext())
            //{
            //    context.Entry<T>(model);
            //    context.SaveChanges();
            //}
        }

        public List<T> Read()
        {
            List<T> list = new List<T>();
            //using (var context = new EstampContext())
            //{
            //    list = context.Set<T>().ToList();
            //}
            return list;
        }

        public T Read(int id)
        {
            T model = Activator.CreateInstance<T>();
            //using (var context = new EstampContext())
            //{
            //    model = context.Set<T>().Find(id);
            //}
            return model;
        }

        public void Update(T model)
        {
            //using (var context = new EstampContext())
            //{
            //    context.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
            //    context.SaveChanges();
            //}
        }

        public void Delete(int id)
        {
            //using (var context = new EstampContext())
            //{
            //    context.Entry<T>(this.Read(id)).State = System.Data.Entity.EntityState.Deleted;
            //    context.SaveChanges();
            //}
        }
    }
}
