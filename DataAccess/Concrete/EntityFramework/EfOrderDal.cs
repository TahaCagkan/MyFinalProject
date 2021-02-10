using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //EfEntityRepositoryBase içerisinde TEntity içerisinde Product ,TContext içeisinde NorthwindContext var.
    //IOrderDal içerisinde özel birşey Detaylar gibi yazarsak sadece onu implemente edicek.
    public class EfOrderDal:EfEntityRepositoryBase<Order,NorthwindContext>,IOrderDal
    {

    }
}
