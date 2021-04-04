using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService:ICrudService<User>
    {
        IDataResult<List<User>> GetByFirstName(string firstName);
        IDataResult<List<User>> GetByLastName(string lastName);
        IDataResult<User> GetByEmail(string email);
    }
}
