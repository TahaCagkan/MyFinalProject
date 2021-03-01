using Business.Abstract;
using Business.BusinessAspects.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Resutls;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        //dependency injection
        IProductDal _productDal;
        ICategoryService _categoryService;
        public ProductManager(IProductDal productDal, ICategoryService categoryService)
        {
            _productDal = productDal;
            _categoryService = categoryService;
        }
        //Ekle
        [SecuredOperation("product.add,admin")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
            //Kategori limiti 10 dan fazla olamaz,Aynı isimle ürün olamaz
            IResult result = BusinessRule.Run(CheckIfProductCountOfCategoryCorrect(product.CategoryId), 
                CheckIfProductNameExits(product.ProductName), CheckIfCategoryHaveLimitExceded());
            if(result != null)
            {
                return result;
            }
            _productDal.Add(product);
            //eklendiği zaman mesaj eklenicek
            return new SuccessResult(Messages.ProductAdded);  
        }

        public IDataResult<List<Product>> GetAll()
        {
            //iş kodları
            //Yetkisi var mı?
            if (DateTime.Now.Hour == 22)
            {
                //bakım zamanı
                return new ErrorDataResult<List<Product>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByCategoryId(int id)
        {
            //Her bir CategoryId,benim gönderdiğim Id ye eşit ise onu gönder
            //SuccessDataResult içerisinde <List<Product> contructer içerisindeki id yi gönderiyoruz
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == id));
        }

        public IDataResult<Product> GetById(int productId)
        {
            //SuccessDataResult içerisinde <Product> contructer içerisindeki id yi gönderiyoruz

            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == productId));
        }

        public IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max)
        {
            //Girilen fiyat aralığana göre Ürünleri getir
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetails()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetails());
        }
        //Güncelle
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Update(Product product)
        {

            throw new NotImplementedException();
        }
        //Ürün için Kategori limiti 10 dan fazla olamaz
        private IResult CheckIfProductCountOfCategoryCorrect(int categoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count();
            if (result >= 10)
            {
                return new ErrorResult(Messages.ProductCountOfCategoryError);
            }
            return new SuccessResult();
        }
        //Aynı Üründen isim olamaz
        private IResult CheckIfProductNameExits(string productName)
        {
            var result = _productDal.GetAll(p => p.ProductName == productName).Any();
            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExits);
            }
            return new SuccessResult();
        }
        //Kategori Limiti Aşıldığında
        private IResult CheckIfCategoryHaveLimitExceded()
        {
            var result = _categoryService.GetAll();
            if (result.Data.Count>15)
            {
                return new ErrorResult(Messages.CategoryHaveLimitExceded);
            }
            return new SuccessResult();
        }
    }
}
