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
    public class Supply_DetailsController : ApiController
    {
        private ecommerceEntities db = new ecommerceEntities();

        // GET: api/Supply_Details
        public IQueryable<Supply_Details> GetSupply_Details()
        {
            return db.Supply_Details;
        }

        // GET: api/Supply_Details/5
        [ResponseType(typeof(Supply_Details))]
        public async Task<IHttpActionResult> GetSupply_Details(int id)
        {
            Supply_Details supply_Details = await db.Supply_Details.FindAsync(id);
            if (supply_Details == null)
            {
                return NotFound();
            }

            return Ok(supply_Details);
        }

        // PUT: api/Supply_Details/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutSupply_Details(int id, Supply_Details supply_Details)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != supply_Details.IdSupply)
            {
                return BadRequest();
            }

            db.Entry(supply_Details).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Supply_DetailsExists(id))
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

        // POST: api/Supply_Details
        [ResponseType(typeof(Supply_Details))]
        public async Task<IHttpActionResult> PostSupply_Details(Supply_Details supply_Details)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Supply_Details.Add(supply_Details);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Supply_DetailsExists(supply_Details.IdSupply))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = supply_Details.IdSupply }, supply_Details);
        }

        // DELETE: api/Supply_Details/5
        [ResponseType(typeof(Supply_Details))]
        public async Task<IHttpActionResult> DeleteSupply_Details(int id)
        {
            Supply_Details supply_Details = await db.Supply_Details.FindAsync(id);
            if (supply_Details == null)
            {
                return NotFound();
            }

            db.Supply_Details.Remove(supply_Details);
            await db.SaveChangesAsync();

            return Ok(supply_Details);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Supply_DetailsExists(int id)
        {
            return db.Supply_Details.Count(e => e.IdSupply == id) > 0;
        }
    }
}