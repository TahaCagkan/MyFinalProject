using Business.Abstract;
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //Loosely coupled = gevşek bağımlılık
        //IoC Container -- Inversion of Control
        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        //Product getirilicek olan GetAll methodu
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            //IDataResult dönüyor
            var result =_productService.GetAll();
            //işlem başarılı ise
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //Product id ye göre getirilicek olan Get methodu
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _productService.GetById(id);
            if(result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        //Ekleme için Post
        [HttpPost("add")]
        public IActionResult Add(Product product)
        {
            var result = _productService.Add(product);
            if(result.Success== true)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
