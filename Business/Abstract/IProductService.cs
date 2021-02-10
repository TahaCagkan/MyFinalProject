using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        //Hepsini getir
        List<Product> GetAll();
        //Kategori Id sine göre getir
        List<Product> GetAllByCategoryId(int id);
        //Min bu kadar Max bukadar aralığında olsun
        List<Product> GetByUnitPrice(decimal min,decimal max);
        //EfProductDal içerisindeki Kategori ve Ürünleri Detaylarını Listelenmektedir.
        List<ProductDetailDto> GetProductDetails();
    }
}
