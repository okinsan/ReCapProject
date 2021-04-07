using Core.Entities;
using Core.Utilities.Results;
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface ICrudService<T>
        where T : class, IEntity, new()
    {
        IDataResult<List<T>> GetAll();
        IDataResult<T> GetById(int id);
        IResult Add(T entity);
        IResult Update(T entity);
        IResult Delete(T entity);
    }
}
