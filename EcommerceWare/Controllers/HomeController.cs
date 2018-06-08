
using EcommerceWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace EcommerceWare.Controllers
{
    public class HomeController : Controller
    {
        Donnees donnees = new Donnees();
        public ActionResult Index()
        {

            donnees.Customers = (CustomersForView)Session["user"];
            chargerDonnees(donnees);

            //Test Data for Categories
            /*List<CategoriesForView> categories = new List<CategoriesForView>();
            CategoriesForView categorie = new CategoriesForView() {
                IdCategory = 0,
                Name_Category = "Special",
                Description_Category = "Categorie Of Trending Products",
                IdParent_Category = null
            };
            categories.Add(categorie);
            categorie = new CategoriesForView()
            {
                IdCategory = 1,
                Name_Category = "SPORTSWEAR",
                Description_Category = "Categorie Of Sport Products",
                IdParent_Category = null
            };
            categories.Add(categorie);
                    categorie = new CategoriesForView()
                    {
                        IdCategory = 6,
                        Name_Category = "NIKE",
                        Description_Category = "Categorie Of nike Products",
                        IdParent_Category = 1
                    };
                    categories.Add(categorie);
                    categorie = new CategoriesForView()
                    {
                        IdCategory = 7,
                        Name_Category = "UNDER ARMOUR",
                        Description_Category = "Categorie Of Under Amour Products",
                        IdParent_Category = 1
                    };
                    categorie = new CategoriesForView()
                    {
                        IdCategory = 8,
                        Name_Category = "ADIDAS",
                        Description_Category = "Categorie Of Adidas Products",
                        IdParent_Category = 1
                    };
                    categories.Add(categorie);
                    categorie = new CategoriesForView()
                    {
                        IdCategory = 9,
                        Name_Category = "PUMA",
                        Description_Category = "Categorie Of PUMA Products",
                        IdParent_Category = 1
                    };
                    categories.Add(categorie);
            categories.Add(categorie);

            categorie = new CategoriesForView()
            {
                IdCategory = 2,
                Name_Category = "MENS",
                Description_Category = "Categorie Of Mens Products",
                IdParent_Category = null
            };
            categories.Add(categorie);
                categorie = new CategoriesForView()
                {
                    IdCategory = 10,
                    Name_Category = "T-SHIRT",
                    Description_Category = "Categorie Of T-Shirt for Mens Products",
                    IdParent_Category = 2
                };
                categories.Add(categorie);
            categorie = new CategoriesForView()
            {
                IdCategory = 3,
                Name_Category = "WOMENS",
                Description_Category = "Categorie Of Womens Products",
                IdParent_Category = null
            };
            categorie = new CategoriesForView()
            {
                IdCategory = 4,
                Name_Category = "Kids",
                Description_Category = "Categorie Of Kids Products",
                IdParent_Category = null
            };
            categories.Add(categorie);
            categorie = new CategoriesForView()
            {
                IdCategory = 5,
                Name_Category = "FASHION",
                Description_Category = "Categorie Of FASHION Products",
                IdParent_Category = null
            };
            categories.Add(categorie);

            donnees.Categories = categories;

            //Test Data for Caroussel

            List<ProductForView> products = new List<ProductForView>();
            ProductForView product = new ProductForView()
            {
                IdProduct = 0,
                IdCategory = 0,
                IdProducer = 0,
                Description_Product = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Gross_Price = 17,
                Net_Price = 23,
                Name_Product = "EcommerceWare0",
                Image_Url = "/Content/images/home/girl1.jpg"
            };
            products.Add(product);
            product = new ProductForView()
            {
                IdProduct = 1,
                IdCategory = 0,
                IdProducer = 0,
                Description_Product = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Gross_Price = 24,
                Net_Price = 41,
                Name_Product = "EcommerceWare0",
                Image_Url = "/Content/images/home/girl2.jpg"
            };
            products.Add(product);
            product = new ProductForView()
            {
                IdProduct = 2,
                IdCategory = 0,
                IdProducer = 0,
                Description_Product = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Gross_Price = 7,
                Net_Price = 20,
                Name_Product = "EcommerceWare0",
                Image_Url = "/Content/images/home/girl3.jpg"
            };
            products.Add(product);
            
            donnees.ProductsCaroussel = products;

            //Test Data for Features Items
            List<ProductForView> productss = new List<ProductForView>();
            ProductForView producte = new ProductForView()
            {
                IdProduct = 0,
                IdCategory = 4,
                IdProducer = 0,
                Description_Product = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Gross_Price = 17,
                Net_Price = 56,
                Quantity_Possessed = 7,
                Name_Product = "Easy Polo Black Edition",
                Image_Url = "/Content/images/home/product1.jpg"
            };
            productss.Add(producte);
            producte = new ProductForView()
            {
                IdProduct = 1,
                IdCategory = 4,
                IdProducer = 0,
                Description_Product = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Gross_Price = 24,
                Net_Price = 76,
                Quantity_Possessed = 7,
                Name_Product = "Easy Polo White Edition",
                Image_Url = "/Content/images/home/product2.jpg"
            };
            productss.Add(producte);
            producte = new ProductForView()
            {
                IdProduct = 2,
                IdCategory = 4,
                IdProducer = 0,
                Description_Product = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Gross_Price = 7,
                Net_Price = 20,
                Quantity_Possessed = 7,
                Name_Product = "Easy Polo Pink Edition",
                Image_Url = "/Content/images/home/product3.jpg"
            };
            productss.Add(producte);
            producte = new ProductForView()
            {
                IdProduct = 2,
                IdCategory = 4,
                IdProducer = 0,
                Description_Product = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Gross_Price = 7,
                Net_Price = 29,
                Quantity_Possessed = 100,
                Name_Product = "Easy Polo Red Edition",
                Image_Url = "/Content/images/home/product4.jpg"
            };
            productss.Add(producte);

            producte = new ProductForView()
            {
                IdProduct = 2,
                IdCategory = 4,
                IdProducer = 0,
                Description_Product = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Gross_Price = 7,
                Net_Price = 36,
                Quantity_Possessed = 0,
                Name_Product = "Easy Polo Blue Edition",
                Image_Url = "/Content/images/home/product5.jpg"
            };
            productss.Add(producte);
            producte = new ProductForView()
            {
                IdProduct = 2,
                IdCategory = 4,
                IdProducer = 0,
                Description_Product = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.",
                Gross_Price = 7,
                Net_Price = 11,
                Quantity_Possessed=7,
                Name_Product = "Easy Polo Grey Edition",
                Image_Url = "/Content/images/home/product6.jpg"
            };
            productss.Add(producte);
            donnees.ProductsFeature = productss;*/

            if (donnees.Categories.FirstOrDefault(cat => cat.IdParent_Category == 1) != null) { ViewBag.test = donnees.Categories.FirstOrDefault(cat => cat.IdParent_Category == 1).Name_Category; }
            return View(donnees);
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

        // GET: Home/AddToCart/5
        [HttpPost]
        public JsonResult AddToCart(int id)
        {
            chargerDonnees(donnees);


            //donnees.Cart = (List<ProductForView>)Session["cart"];
            donnees.Cart.Add(donnees.ProductsFeature.SingleOrDefault(p => p.IdProduct == id));
            Session["cart"] = donnees.Cart;
            Res res = new Res() { Value = true };
            return Json(res, JsonRequestBehavior.AllowGet);
        }

        public void chargerDonnees(Donnees donnees)
        {
            HttpClient client = new HttpClient();

            // Update port # in the following line.
            client.BaseAddress = new Uri("http://192.168.1.12:8088/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = client.GetAsync("api/products").Result;
            if (response.IsSuccessStatusCode)
            {
                donnees.ProductsFeature = response.Content.ReadAsAsync<List<ProductForView>>().Result;
            }

            response = client.GetAsync("api/products").Result;
            if (response.IsSuccessStatusCode)
            {
                donnees.ProductsCaroussel = response.Content.ReadAsAsync<List<ProductForView>>().Result;
            }

            response = client.GetAsync("api/categories").Result;
            if (response.IsSuccessStatusCode)
            {
                donnees.Categories = response.Content.ReadAsAsync<List<CategoriesForView>>().Result;
            }

            if (Session["cart"] == null)
            {
                donnees.Cart = new List<ProductForView>();
                Session["cart"] = donnees.Cart;
            }
            else
            {
                donnees.Cart = (List<ProductForView>)HttpContext.Session["cart"];
            }

        }
        public ActionResult Cart()
        {
            ViewBag.Message = "Welcome to your Cart.";

            return View();
        }
        public class Res { public Boolean Value { get; set; } }
    }
}