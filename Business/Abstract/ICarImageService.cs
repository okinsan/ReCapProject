using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICarImageService : ICrudService<CarImage>
    {
        IDataResult<List<CarImage>> GetByCarId(int carId);
    }
}
