using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EcommerceWare.API.Models;

namespace EcommerceWare.API.Controllers
{
    public class ProductsController : ApiController
    {
        /// <summary>
        /// renvoie la liste des articles
        /// </summary>
        /// <returns></returns>
        IViewService s;
        public ProductsController()
        {
             s = new ViewServiceImp();
        }

        public IEnumerable<ProductForView> GetProducts()
        {
            return s.GetProductsForView();
        }

        // GET api/Ecommerce/5
        public ProductForView GetProduct(int id)
        {
          return  s.GetProductForView(id);
        }

        
    }
}
