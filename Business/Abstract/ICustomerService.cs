using Core.Utilities.Results;
using Entities.Concrete;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICustomerService : ICrudService<Customer>
    {
        IDataResult<Customer> GetByUserId(int userId);
        IDataResult<List<Customer>> GetByCompanyName(string companyName);
    }
}
