using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IRentalService : ICrudService<Rental>
    {
        IDataResult<Rental> GetByCarID(int carId);
        IDataResult<List<Rental>> GetByCustomerID(int customerId);
        IDataResult<List<Rental>> GetByRentDate(DateTime dateTime);
        IDataResult<List<Rental>> GetByReturnDate(DateTime dateTime);
    }
}
