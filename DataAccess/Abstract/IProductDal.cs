using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //IEntityRepository 'i Product göre şekillendirebilirsin
    public interface IProductDal : IEntityRepository<Product>
    {
        //ProductDetailDto istediğimiz Detaylara göre Ürün işlemi yapabiliriz.
        List<ProductDetailDto> GetProductDetails();
    }
}
