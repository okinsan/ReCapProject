using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(CarImage entity)
        {
            var result = BusinessRules.Run(
                CheckIfCarImageLimitExceded(entity.CarId));
            if (result != null)
            {
                return result;
            }
            
            _carImageDal.Add(entity);
            return new SuccessResult(Messages.CarImageAdded);
        }

        public IResult Delete(CarImage entity)
        {
            _carImageDal.Delete(entity);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(), Messages.CarImagesListed);
        }

        public IDataResult<List<CarImage>> GetByCarId(int carId)
        {
            //Aracın resmi yoksa
            
            return new SuccessDataResult<List<CarImage>>(CheckIfCarNoImage(carId), Messages.CarImagesListed);
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(i => i.Id == id));
        }

        public IResult Update(CarImage entity)
        {
            _carImageDal.Update(entity);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        private IResult CheckIfCarImageLimitExceded(int carId)
        {
            return (_carImageDal.GetAll(i=>i.CarId==carId).Count<5)
                ? new SuccessResult()
                : new ErrorResult();
        }

        private List<CarImage> CheckIfCarNoImage(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId);
            if (!result.Any())
                return new List<CarImage> { new CarImage { CarId = carId, ImagePath = @"D:\MyProjects\ReCapProject\WebAPI\wwwroot\carImages\123f539b-5012-4a2c-8bb2-9d23fc27fd2e.jpg" } };
            return result;
        }
    }
}
