﻿using EcommerceWare.API.Models;
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
        List<ProductForView> productsCaroussel;
        List<ProductForView> productsFeature;
        List<CategoriesForView> categories;

        public List<ProductForView> ProductsCaroussel { get => productsCaroussel; set => productsCaroussel = value; }
        public List<CategoriesForView> Categories { get => categories; set => categories = value; }
        public List<ProductForView> ProductsFeature { get => productsFeature; set => productsFeature = value; }
        /*List<Products> productsCaroussel;
Login_informations login_Informations;
Customers customers;*/
    }
}