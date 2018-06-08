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
        public CustomersForView Post([FromBody]Login_informationsForView li_u)
        {
            ecommerceEntities db = new ecommerceEntities();

            //   db.InsertCustomer("francis", "123", "Le Roi", "King", "fr@fr.com", "696598600", "jk", "io", "11-400", "kl", 15, "op");

            Login_informations li = db.Login_informations.SingleOrDefault(l => l.Login == li_u.Login && l.Password == li_u.Password);
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

        /* public Boolean  Post(String login,String password,String email, String last_name)
         {
             /*ecommerceEntities db = new ecommerceEntities();
             db.InsertCustomer(login, password, last_name, last_name, email, "696598600", "jk", "io", "11-400", "kl", 15, "op");
            return true;
             

         }*/

        public Boolean PutAddCustomer(SignUpData data)
        {
            ecommerceEntities db = new ecommerceEntities();
            db.InsertCustomer(data.Login, data.Password, data.Last_name, data.Last_name, data.Email, "696598600", "jk", "io", "11-400", "kl", 15, "op");
            return true;
        }

        // DELETE: api/Customers/5
        public void Delete(int id)
        {
        }
    }
}
