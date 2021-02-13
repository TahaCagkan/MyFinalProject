using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //Data Transformation Object
        //IoC
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            //ben InMemory çalışıcam demek
            ProductManager productManager = new ProductManager(new EfProductDal());

            //foreach (var product in productManager.GetAll())
            //foreach (var product in productManager.GetAllByCategoryId(2))
            //foreach (var product in productManager.GetByUnitPrice(40, 100))
            var result = productManager.GetProductDetails();
            if(result.Success)
            {
                foreach (var product in result.Data)
                {
                    Console.WriteLine(product.ProductName + "/" + product.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
           
        }
    }
}
