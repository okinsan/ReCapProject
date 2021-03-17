using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new EfCarDal());

            //foreach (var item in carManager.GetCarsByColorId(1))
            //{
            //    Console.WriteLine(item.Description);
            //}

            EfCarDal efCarDal = new EfCarDal();
            efCarDal.Add(new Car
            {
                Id=6, BrandId=1, ColorId=2, DailyPrice=450, ModelYear=2020, Description="i35"
            });
        }
    }
}
