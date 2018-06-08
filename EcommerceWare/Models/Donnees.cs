
using EcommerceWare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWare.Models
{
    public class Donnees
    {
        public Donnees()
        {

        }
        public List<ProductForView> ProductsCaroussel { get; set; }
        public List<CategoriesForView> Categories { get; set; }
        public List<ProductForView> ProductsFeature { get; set; }
        public CustomersForView Customers { get; set; }
        public List<ProductForView> Cart { get; set; }
        /*List<Products> productsCaroussel;
Login_informations login_Informations;
Customers customers;*/
    }
}