using Business.Abstract;
using Core.Utilities.Resutls;
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
        public IDataResult<List<Category>> GetAll()
        {
            //iş kodları
            return new SuccessDataResult<List<Category>>(_categorDal.GetAll());
        }
        
        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categorDal.Get(c => c.CategoryId == categoryId));
        }
    }
}
