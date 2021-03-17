using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCarDal : ICarDal
    {
        public void Add(Car entity)
        {
            if (entity.Description.Length<2)
            {
                Console.WriteLine("Tanım en az 2 karakter olmalı");
                return;
            }
            else if (entity.DailyPrice<=0)
            {
                Console.WriteLine("Günlük kirayı hatalı girdiniz");
                return;
            }
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
            Console.WriteLine("Ekleme Başarılı");
        }

        public void Delete(Car entity)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            using (ReCapDBContext context=new ReCapDBContext())
            {
                return context.Set<Car>().SingleOrDefault(filter);
            }
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                return filter==null? context.Set<Car>().ToList() : context.Set<Car>().Where(filter).ToList();
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

        public void Update(Car entity)
        {
            using (ReCapDBContext context = new ReCapDBContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
