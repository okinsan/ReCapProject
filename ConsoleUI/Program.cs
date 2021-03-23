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


            //EfColorDal efColorDal = new EfColorDal();
            //efColorDal.Update(new Color { Id = 6, ColorName = "Siyah" });
            //CRUDBrand();
            //BrandTest();
            CarTest();
            //ColorTest();
        }

        private static void CRUDBrand()
        {
            EfBrandDal efBrandDal = new EfBrandDal();
            //efBrandDal.Add(new Brand { BrandName = "Ford" });
            //efBrandDal.Update(new Brand { Id = 9, BrandName = "Chevrolet" });
            efBrandDal.Delete(new Brand { Id = 9 });
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success)
            {

                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.CarName + "\t" + item.BrandName + "\t" + item.ColorName + "\t" + item.DailyPrice);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
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
