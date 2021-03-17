﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Entities.Concrete;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IColorDal : IEntityRepository<Entities.Concrete.Color>
    {
    }
}
