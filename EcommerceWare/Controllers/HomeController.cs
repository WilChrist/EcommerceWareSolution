using EcommerceWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWare.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Product> products = new List<Product>();
            Product product = new Product()
            {
                ProductId = 0,
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Price = 17,
                CostPrice=23,
                Name = "EcommerceWare0",
                ImageUrl= "/Content/images/home/girl1.jpg"
            };
            products.Add(product);
            product = new Product()
            {
                ProductId = 1,
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Price = 24,
                CostPrice = 41,
                Name = "EcommerceWare1",
                ImageUrl = "/Content/images/home/girl2.jpg"
            };
            products.Add(product);
            product = new Product()
            {
                ProductId = 2,
                Description = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Price = 7,
                CostPrice = 20,
                Name = "EcommerceWare2",
                ImageUrl = "/Content/images/home/girl3.jpg"
            };
            products.Add(product);
            return View(products);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}