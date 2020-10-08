using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ShopProduct.Models;

namespace ShopProduct.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {

        private readonly ShopEntities _context = new ShopEntities();

    [HttpPost]

    [Authorize]
    [Route("api/Bank/Create")]
    public IHttpActionResult Create(ProductModel productModel)
    {
        var product = new Product()
        {
            ID = productModel.ID,
            Name = productModel.Name,
            price = productModel.price,
            qty= productModel.qty            
        };
        _context.Products.Add(product);
        _context.SaveChanges();
        return Ok("Success");
    }

    [HttpGet]
    [Authorize]
    [Route("api/Bank/GetAll")]
    public IHttpActionResult GetAll()
    {
        var banks = _context.Products.ToList();
        return Ok(banks);
    }


    [HttpPost]
    [Authorize]
    [Route("api/Bank/Modify")]
    public IHttpActionResult Modify(ProductModel productModel)
    {
        var product = new Product()
        {
            ID = productModel.ID,
            Name = productModel.Name,
            price = productModel.price,
            qty = productModel.qty
        };
        _context.Entry(product).State = System.Data.Entity.EntityState.Modified;
        _context.SaveChanges();
        return Ok("Success");
    }


    [HttpDelete]
    [Authorize]
    [Route("api/Bank/Delete/{id}")]
    public IHttpActionResult Delete(int id)
    {
        var product = _context.Products.SingleOrDefault(e => e.ID == id);
        _context.Products.Remove(product);
        _context.SaveChanges();
        return Ok("Success");
    }

    }
}
