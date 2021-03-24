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
            //CarTest();
            //ColorTest();
            //UserTest();
            //CustomerTest();
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result=rentalManager.Add(new Rental { CarId = 5, CustomerId = 1, RentDate = DateTime.Now });
            Console.WriteLine(result.Message);

            foreach (var item in rentalManager.GetAll().Data)
            {
                Console.WriteLine(item.Id+"/"+item.CarId);
            }
            
        }

        private static void CustomerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer { UserId = 1, CompanyName = "Knsn" });
            customerManager.Add(new Customer { UserId = 1, CompanyName = "Snkn" });
            customerManager.Add(new Customer { UserId = 2, CompanyName = "fasfew" });
            foreach (var item in customerManager.GetAll().Data)
            {
                Console.WriteLine(item.CompanyName);
            }
        }

        private static void UserTest()
        {
            UserManager userManager = new UserManager(new EfUserDal());
            userManager.Add(new User { FirstName = "Hasan", LastName = "Boğuldu", Email = "oguzk@oguz.com", Password = "13548ef" });
            foreach (var item in userManager.GetAll().Data)
            {
                Console.WriteLine(item.Id + ") " + item.FirstName + " " + item.LastName);
            }
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
            foreach (var item in brandManager.GetAll().Data)
            {
                Console.WriteLine(item.BrandName);
            }
        }

        private static void ColorTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var item in colorManager.GetAll().Data)
            {
                Console.WriteLine(item.ColorName);
            }
        }
    }
}
