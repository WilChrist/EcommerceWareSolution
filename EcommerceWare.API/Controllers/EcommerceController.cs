using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EcommerceWare.API.Models;

namespace EcommerceWare.API.Controllers
{
    public class EcommerceController : ApiController
    {
        /// <summary>
        /// renvoie la liste des articles
        /// </summary>
        /// <returns></returns>
        public ProductForView Get()
        {
            ecommerceEntities db = new ecommerceEntities();

            return new ProductForView(db.Products.SingleOrDefault(p => p.IdProduct == 1));
        }

        // GET api/Ecommerce/5
        public IEnumerable<Products> Gettest(int id)
        {
            ecommerceEntities db = new ecommerceEntities();
            return db.Products;
        }

        // POST api/Ecommerce
        public void Post([FromBody]string value)
        {
        }

        // PUT api/Ecommerce/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/Ecommerce/5
        public void Delete(int id)
        {
        }
    }
}
