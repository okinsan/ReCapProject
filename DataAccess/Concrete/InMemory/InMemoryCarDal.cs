using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id=1, BrandId=1, ColorId=1, ModelYear=1999, DailyPrice=100, Description="Doğan"},
                new Car{Id=1, BrandId=2, ColorId=2, ModelYear=2010, DailyPrice=150, Description="Getz"},
                new Car{Id=1, BrandId=2, ColorId=3, ModelYear=2015, DailyPrice=200, Description="i10"},
                new Car{Id=1, BrandId=2, ColorId=4, ModelYear=2017, DailyPrice=250, Description="i20"},
                new Car{Id=1, BrandId=2, ColorId=2, ModelYear=2018, DailyPrice=300, Description="i30"},
                new Car{Id=1, BrandId=3, ColorId=1, ModelYear=2019, DailyPrice=400, Description="Mercedes"},
                new Car{Id=1, BrandId=4, ColorId=3, ModelYear=2020, DailyPrice=450, Description="Audi"},
                new Car{Id=1, BrandId=5, ColorId=4, ModelYear=2021, DailyPrice=500, Description="BMW"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car) => _cars.Remove(_cars.SingleOrDefault(c => c.Id == car.Id));

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll() => _cars;

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return filter == null ? _cars : _cars.Where(c => c.DailyPrice < 13).ToList();//uydurdum
            //return filter == null ? _cars.ToList() : _cars.Where(filter).ToList();
        }

        public List<Car> GetById(int id) => _cars.Where(c => c.Id == id).ToList();

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
