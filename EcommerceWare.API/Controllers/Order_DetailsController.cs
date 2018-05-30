using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using EcommerceWareAPI.Models;

namespace EcommerceWareAPI.Controllers
{
    public class Order_DetailsController : ApiController
    {
        private ecommerceEntities db = new ecommerceEntities();

        // GET: api/Order_Details
        public IQueryable<Order_Details> GetOrder_Details()
        {
            return db.Order_Details;
        }

        // GET: api/Order_Details/5
        [ResponseType(typeof(Order_Details))]
        public IHttpActionResult GetOrder_Details(int id)
        {
            Order_Details order_Details = db.Order_Details.Find(id);
            if (order_Details == null)
            {
                return NotFound();
            }

            return Ok(order_Details);
        }

        // PUT: api/Order_Details/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrder_Details(int id, Order_Details order_Details)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order_Details.IdOrder)
            {
                return BadRequest();
            }

            db.Entry(order_Details).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Order_DetailsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Order_Details
        [ResponseType(typeof(Order_Details))]
        public IHttpActionResult PostOrder_Details(Order_Details order_Details)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Order_Details.Add(order_Details);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (Order_DetailsExists(order_Details.IdOrder))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = order_Details.IdOrder }, order_Details);
        }

        // DELETE: api/Order_Details/5
        [ResponseType(typeof(Order_Details))]
        public IHttpActionResult DeleteOrder_Details(int id)
        {
            Order_Details order_Details = db.Order_Details.Find(id);
            if (order_Details == null)
            {
                return NotFound();
            }

            db.Order_Details.Remove(order_Details);
            db.SaveChanges();

            return Ok(order_Details);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Order_DetailsExists(int id)
        {
            return db.Order_Details.Count(e => e.IdOrder == id) > 0;
        }
    }
}