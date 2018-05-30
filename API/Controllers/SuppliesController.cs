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
    public class SuppliesController : ApiController
    {
        private ecommerceEntities db = new ecommerceEntities();

        // GET: api/Supplies
        public IQueryable<Supply> GetSupplies()
        {
            return db.Supplies;
        }

        // GET: api/Supplies/5
        [ResponseType(typeof(Supply))]
        public async Task<IHttpActionResult> GetSupply(int id)
        {
            Supply supply = await db.Supplies.FindAsync(id);
            if (supply == null)
            {
                return NotFound();
            }

            return Ok(supply);
        }

        // PUT: api/Supplies/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSupply(int id, Supply supply)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != supply.IdSupply)
            {
                return BadRequest();
            }

            db.Entry(supply).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SupplyExists(id))
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

        // POST: api/Supplies
        [ResponseType(typeof(Supply))]
        public async Task<IHttpActionResult> PostSupply(Supply supply)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Supplies.Add(supply);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = supply.IdSupply }, supply);
        }

        // DELETE: api/Supplies/5
        [ResponseType(typeof(Supply))]
        public async Task<IHttpActionResult> DeleteSupply(int id)
        {
            Supply supply = await db.Supplies.FindAsync(id);
            if (supply == null)
            {
                return NotFound();
            }

            db.Supplies.Remove(supply);
            await db.SaveChangesAsync();

            return Ok(supply);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool SupplyExists(int id)
        {
            return db.Supplies.Count(e => e.IdSupply == id) > 0;
        }
    }
}