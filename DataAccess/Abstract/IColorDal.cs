using Core.DataAccess;
using Color = Entities.Concrete.Color;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Color>
    {
    }
}
