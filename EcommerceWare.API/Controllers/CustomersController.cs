using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EcommerceWare.API.Models;

namespace EcommerceWare.API.Controllers
{
    public class CustomersController : ApiController
    {
        // GET: api/Customers
        public CustomersForView Get(String login,String password)
        {
            ecommerceEntities db = new ecommerceEntities();
            
           //   db.InsertCustomer("francis", "123", "Le Roi", "King", "fr@fr.com", "696598600", "jk", "io", "11-400", "kl", 15, "op");

           Login_informations li= db.Login_informations.SingleOrDefault(l => l.Login == login && l.Password == password);
            CustomersForView user;
            if (li != null)
            {
                user = new CustomersForView(db.Customers.SingleOrDefault(c => c.IdLogin_information == li.IdLogin_information));
                return user;
            }
            else
            {
                return null;
            }
            
        }

        // GET: api/Customers/5
        /*public CustomersForView Post()
        {
            ecommerceEntities db = new ecommerceEntities();

            //   db.InsertCustomer("francis", "123", "Le Roi", "King", "fr@fr.com", "696598600", "jk", "io", "11-400", "kl", 15, "op");

            Login_informations li = db.Login_informations.SingleOrDefault(l => l.Login == login && l.Password == password);
            CustomersForView user;
            if (li != null)
            {
                user = new CustomersForView(db.Customers.SingleOrDefault(c => c.IdLogin_information == li.IdLogin_information));
                return user;
            }
            else
            {
                return null;
            }
        }*/

        // POST: api/Customers
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Customers/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
        }
    }
}
