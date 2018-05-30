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
    public class Shippment_MethodsController : ApiController
    {
        private ecommerceEntities db = new ecommerceEntities();

        // GET: api/Shippment_Methods
        public IQueryable<Shippment_Methods> GetShippment_Methods()
        {
            return db.Shippment_Methods;
        }

        // GET: api/Shippment_Methods/5
        [ResponseType(typeof(Shippment_Methods))]
        public async Task<IHttpActionResult> GetShippment_Methods(int id)
        {
            Shippment_Methods shippment_Methods = await db.Shippment_Methods.FindAsync(id);
            if (shippment_Methods == null)
            {
                return NotFound();
            }

            return Ok(shippment_Methods);
        }

        // PUT: api/Shippment_Methods/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutShippment_Methods(int id, Shippment_Methods shippment_Methods)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != shippment_Methods.IdShippment_Method)
            {
                return BadRequest();
            }

            db.Entry(shippment_Methods).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Shippment_MethodsExists(id))
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

        // POST: api/Shippment_Methods
        [ResponseType(typeof(Shippment_Methods))]
        public async Task<IHttpActionResult> PostShippment_Methods(Shippment_Methods shippment_Methods)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Shippment_Methods.Add(shippment_Methods);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = shippment_Methods.IdShippment_Method }, shippment_Methods);
        }

        // DELETE: api/Shippment_Methods/5
        [ResponseType(typeof(Shippment_Methods))]
        public async Task<IHttpActionResult> DeleteShippment_Methods(int id)
        {
            Shippment_Methods shippment_Methods = await db.Shippment_Methods.FindAsync(id);
            if (shippment_Methods == null)
            {
                return NotFound();
            }

            db.Shippment_Methods.Remove(shippment_Methods);
            await db.SaveChangesAsync();

            return Ok(shippment_Methods);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Shippment_MethodsExists(int id)
        {
            return db.Shippment_Methods.Count(e => e.IdShippment_Method == id) > 0;
        }
    }
}