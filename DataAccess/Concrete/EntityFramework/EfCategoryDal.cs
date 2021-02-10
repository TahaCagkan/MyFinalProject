﻿using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //EfEntityRepositoryBase içerisinde TEntity içerisinde Product ,TContext içeisinde NorthwindContext var.
    //ICategoryDal içerisinde özel birşey Detaylar gibi yazarsak sadece onu implemente edicek.
    public class EfCategoryDal : EfEntityRepositoryBase<Category, NorthwindContext>, ICategoryDal
    {
       
    }
}
