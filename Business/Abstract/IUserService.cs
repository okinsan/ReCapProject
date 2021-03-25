using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IUserService
    {
        Result Add(User user);
        Result Delete(User user);
        Result Update(User user);
        IDataResult<List<User>> GetAll();
        IDataResult<User> GetByID(int userId);
        IDataResult<List<User>> GetByFirstName(string firstName);
        IDataResult<List<User>> GetByLastName(string lastName);
        IDataResult<User> GetByEmail(string email);


    }
}
