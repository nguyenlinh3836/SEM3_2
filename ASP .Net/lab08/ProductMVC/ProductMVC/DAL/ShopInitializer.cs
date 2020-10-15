using Microsoft.Ajax.Utilities;
using ProductMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductMVC.DAL
{
    public class ShopInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ShopContext>
    {
        protected override void Seed(ShopContext context)
        {
            var products = new List<Product>
            {
            new Product{name="In The End",Price=2.8,EnrollmentDate=DateTime.Parse("2020-09-01")},
            new Product{name="Bad Guy",Price=15,EnrollmentDate=DateTime.Parse("2020-09-01")},
            new Product{name="Beautiful Day",Price=1.5,EnrollmentDate=DateTime.Parse("2020-09-01")}
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var category = new List<Category>
            {
                new Category{title = "Rock",CategoryID=1001},
                new Category{title = "Pop",CategoryID=1002},
                new Category{title = "Ballad",CategoryID=1003}
            };
            category.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
                new Enrollment{ProductId=1,CategoryID=1001},
                new Enrollment{ProductId=1,CategoryID=1002},
                new Enrollment{ProductId=2,CategoryID=1003}
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();


        }
      
    }
}