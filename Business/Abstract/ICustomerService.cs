using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICustomerService:ICrudService<Customer>
    {
        IDataResult<Customer> GetByUserId(int userId);
        IDataResult<List<Customer>> GetByCompanyName(string companyName);
    }
}
