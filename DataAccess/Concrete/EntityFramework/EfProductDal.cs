using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //EfEntityRepositoryBase içerisinde TEntity içerisinde Product ,TContext içeisinde NorthwindContext var.
    //IProductDal içerisinde özel birşey Detaylar gibi yazarsak sadece onu implemente edicek.
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        //DTO içerisindeki bilgilere özel Ürün ve Kategori ile ilgili ilişkili bilgileri Detyalarına göre Listelemek için join yapıldı 
        public List<ProductDetailDto> GetProductDetails()
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                //ürünlerle kategorileri joinle
                var result = from p in context.Products
                             join c in context.Categories
                             on p.CategoryId equals c.CategoryId
                             select new ProductDetailDto
                             {
                                 ProductId =p.ProductId,
                                 ProductName = p.ProductName,
                                 CategoryName = c.CategoryName,
                                 UnitsInStock = p.UnitsInStock
                             };

                return result.ToList();
            }
        }
    }
}
