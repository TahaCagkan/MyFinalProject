﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //IEntityRepository 'i Product göre şekillendirebilirsin
    public interface IProductDal:IEntityRepository<Product>
    {

    }
}
