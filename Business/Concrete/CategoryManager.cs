using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categorDal;
        //bağlılığımı constructor injection yapıyorum
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categorDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            //iş kodları
            return _categorDal.GetAll();
        }
        
        public Category GetById(int categoryId)
        {
            return _categorDal.Get(c => c.CategoryId == categoryId);
        }
    }
}
