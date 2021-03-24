using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService
    {
        Result Add(Customer customer);
        IDataResult<List<Customer>> GetAll();
        IDataResult<Customer> GetByID(int customerId);
        IDataResult<Customer> GetByUserId(int userId);
        IDataResult<List<Customer>> GetByCompanyName(string companyName);

    }
}
