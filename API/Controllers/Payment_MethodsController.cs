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
    public class Payment_MethodsController : ApiController
    {
        private ecommerceEntities db = new ecommerceEntities();

        // GET: api/Payment_Methods
        public IQueryable<Payment_Methods> GetPayment_Methods()
        {
            return db.Payment_Methods;
        }

        // GET: api/Payment_Methods/5
        [ResponseType(typeof(Payment_Methods))]
        public async Task<IHttpActionResult> GetPayment_Methods(int id)
        {
            Payment_Methods payment_Methods = await db.Payment_Methods.FindAsync(id);
            if (payment_Methods == null)
            {
                return NotFound();
            }

            return Ok(payment_Methods);
        }

        // PUT: api/Payment_Methods/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutPayment_Methods(int id, Payment_Methods payment_Methods)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != payment_Methods.IdPayment_Method)
            {
                return BadRequest();
            }

            db.Entry(payment_Methods).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Payment_MethodsExists(id))
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

        // POST: api/Payment_Methods
        [ResponseType(typeof(Payment_Methods))]
        public async Task<IHttpActionResult> PostPayment_Methods(Payment_Methods payment_Methods)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Payment_Methods.Add(payment_Methods);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = payment_Methods.IdPayment_Method }, payment_Methods);
        }

        // DELETE: api/Payment_Methods/5
        [ResponseType(typeof(Payment_Methods))]
        public async Task<IHttpActionResult> DeletePayment_Methods(int id)
        {
            Payment_Methods payment_Methods = await db.Payment_Methods.FindAsync(id);
            if (payment_Methods == null)
            {
                return NotFound();
            }

            db.Payment_Methods.Remove(payment_Methods);
            await db.SaveChangesAsync();

            return Ok(payment_Methods);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Payment_MethodsExists(int id)
        {
            return db.Payment_Methods.Count(e => e.IdPayment_Method == id) > 0;
        }
    }
}