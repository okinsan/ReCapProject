using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.EntityFramework
{
    public class EfEntityRepositoryBase<TEntity, TContext>:IEntityRepository<TEntity>
        where TEntity:class,IEntity,new()
        where TContext:DbContext, new()
    {
        public void Add(TEntity entity)
        {
            //if (entity.Description.Length < 2)
            //{
            //    Console.WriteLine("Tanım en az 2 karakter olmalı");
            //    return;
            //}
            //else if (entity.DailyPrice <= 0)
            //{
            //    Console.WriteLine("Günlük kirayı hatalı girdiniz");
            //    return;
            //}
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
            Console.WriteLine("Ekleme Başarılı");
        }

        public void Delete(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContext context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContext context = new TContext())
            {
                return filter == null ? context.Set<TEntity>().ToList() : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        //public Car GetCarsByBrandId(Expression<Func<Car, bool>> filter)
        //{
        //    using (ReCapDBContext context = new ReCapDBContext())
        //    {
        //        return context.Set<Car>().SingleOrDefault(filter);
        //    }
        //}

        //public Car GetCarsByColorId(Expression<Func<Car, bool>> filter)
        //{
        //    using (ReCapDBContext context = new ReCapDBContext())
        //    {
        //        return context.Set<Car>().SingleOrDefault(filter);
        //    }
        //}

        public void Update(TEntity entity)
        {
            using (TContext context = new TContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
