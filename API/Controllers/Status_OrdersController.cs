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
using API.Models;

namespace API.Controllers
{
    public class Status_OrdersController : ApiController
    {
        private ecommerceEntities db = new ecommerceEntities();

        // GET: api/Status_Orders
        public IQueryable<Status_Orders> GetStatus_Orders()
        {
            return db.Status_Orders;
        }

        // GET: api/Status_Orders/5
        [ResponseType(typeof(Status_Orders))]
        public async Task<IHttpActionResult> GetStatus_Orders(int id)
        {
            Status_Orders status_Orders = await db.Status_Orders.FindAsync(id);
            if (status_Orders == null)
            {
                return NotFound();
            }

            return Ok(status_Orders);
        }

        // PUT: api/Status_Orders/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutStatus_Orders(int id, Status_Orders status_Orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != status_Orders.IdStatus_Order)
            {
                return BadRequest();
            }

            db.Entry(status_Orders).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Status_OrdersExists(id))
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

        // POST: api/Status_Orders
        [ResponseType(typeof(Status_Orders))]
        public async Task<IHttpActionResult> PostStatus_Orders(Status_Orders status_Orders)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Status_Orders.Add(status_Orders);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = status_Orders.IdStatus_Order }, status_Orders);
        }

        // DELETE: api/Status_Orders/5
        [ResponseType(typeof(Status_Orders))]
        public async Task<IHttpActionResult> DeleteStatus_Orders(int id)
        {
            Status_Orders status_Orders = await db.Status_Orders.FindAsync(id);
            if (status_Orders == null)
            {
                return NotFound();
            }

            db.Status_Orders.Remove(status_Orders);
            await db.SaveChangesAsync();

            return Ok(status_Orders);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Status_OrdersExists(int id)
        {
            return db.Status_Orders.Count(e => e.IdStatus_Order == id) > 0;
        }
    }
}