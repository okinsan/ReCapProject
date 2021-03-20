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
            CarTest();

            //EfCarDal efCarDal = new EfCarDal();
            //efCarDal.Add(new Car
            //{
            //    CarName="Megan", BrandId=2, ColorId=3, DailyPrice=400, ModelYear=2018, Description="Manuel"
            //});

            //BrandTest();

            //ColorTest();
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            foreach (var item in carManager.GetCarDetails())
            {
                Console.WriteLine(item.CarName + "/" + item.BrandName);
            }
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll())
            {
                Console.WriteLine(item.ColorName);
            }
        }
    }
}
