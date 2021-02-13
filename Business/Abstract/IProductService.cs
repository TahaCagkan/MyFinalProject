using Core.Utilities.Resutls;
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
        //List<Product> GetAll();
        //IDataResult hem Data dönücek hemde mesaj işlemlerimizi yapılıcak
        IDataResult<List<Product>> GetAll();
        //Kategori Id sine göre getir
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        //Min bu kadar Max bukadar aralığında olsun
        IDataResult<List<Product>> GetByUnitPrice(decimal min,decimal max);
        //EfProductDal içerisindeki Kategori ve Ürünleri Detaylarını Listelenmektedir.
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        //özel olarak o ürüne ait bilgileri getirme
        IDataResult<Product> GetById(int productId);
        //Ürün ekleme
        IResult Add(Product product);
    }
}
