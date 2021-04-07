using Core.Entities.Concrete;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IUserService : ICrudService<User>
    {
        IDataResult<List<User>> GetByFirstName(string firstName);
        IDataResult<List<User>> GetByLastName(string lastName);
        User GetByEmail(string email);
        IDataResult<List<OperationClaim>> GetClaims(User user);
    }
}
