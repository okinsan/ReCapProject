using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IRentalService
    {
        Result Add(Rental rental);
        IDataResult<List<Rental>> GetAll();
        IDataResult<Rental> GetByID(int rentalId);
        IDataResult<Rental> GetByCarID(int carId);
        IDataResult<List<Rental>> GetByCustomerID(int customerId);
        IDataResult<List<Rental>> GetByRentDate(DateTime dateTime);
        IDataResult<List<Rental>> GetByReturnDate(DateTime dateTime);
    }
}
