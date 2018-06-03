using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using EcommerceWare;

namespace EcommerceWare.Controllers
{
    public class Order_Controller : ApiController
    {
        private ASP_ecommerceEntities1 db = new ASP_ecommerceEntities1();

        // GET: api/Order_
        public IQueryable<Order_> GetOrder_()
        {
            return db.Order_;
        }

        // GET: api/Order_/5
        [ResponseType(typeof(Order_))]
        public async Task<IHttpActionResult> GetOrder_(int id)
        {
            Order_ order_ = await db.Order_.FindAsync(id);
            if (order_ == null)
            {
                return NotFound();
            }

            return Ok(order_);
        }

        // PUT: api/Order_/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutOrder_(int id, Order_ order_)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order_.NumOrder)
            {
                return BadRequest();
            }

            db.Entry(order_).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Order_Exists(id))
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

        // POST: api/Order_
        [ResponseType(typeof(Order_))]
        public async Task<IHttpActionResult> PostOrder_(Order_ order_)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Order_.Add(order_);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = order_.NumOrder }, order_);
        }

        // DELETE: api/Order_/5
        [ResponseType(typeof(Order_))]
        public async Task<IHttpActionResult> DeleteOrder_(int id)
        {
            Order_ order_ = await db.Order_.FindAsync(id);
            if (order_ == null)
            {
                return NotFound();
            }

            db.Order_.Remove(order_);
            await db.SaveChangesAsync();

            return Ok(order_);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Order_Exists(int id)
        {
            return db.Order_.Count(e => e.NumOrder == id) > 0;
        }
    }
}