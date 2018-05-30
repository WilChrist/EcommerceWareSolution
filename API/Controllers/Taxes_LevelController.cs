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
    public class Taxes_LevelController : ApiController
    {
        private ecommerceEntities db = new ecommerceEntities();

        // GET: api/Taxes_Level
        public IQueryable<Taxes_Level> GetTaxes_Level()
        {
            return db.Taxes_Level;
        }

        // GET: api/Taxes_Level/5
        [ResponseType(typeof(Taxes_Level))]
        public async Task<IHttpActionResult> GetTaxes_Level(int id)
        {
            Taxes_Level taxes_Level = await db.Taxes_Level.FindAsync(id);
            if (taxes_Level == null)
            {
                return NotFound();
            }

            return Ok(taxes_Level);
        }

        // PUT: api/Taxes_Level/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutTaxes_Level(int id, Taxes_Level taxes_Level)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != taxes_Level.IdTax_Level)
            {
                return BadRequest();
            }

            db.Entry(taxes_Level).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Taxes_LevelExists(id))
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

        // POST: api/Taxes_Level
        [ResponseType(typeof(Taxes_Level))]
        public async Task<IHttpActionResult> PostTaxes_Level(Taxes_Level taxes_Level)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Taxes_Level.Add(taxes_Level);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = taxes_Level.IdTax_Level }, taxes_Level);
        }

        // DELETE: api/Taxes_Level/5
        [ResponseType(typeof(Taxes_Level))]
        public async Task<IHttpActionResult> DeleteTaxes_Level(int id)
        {
            Taxes_Level taxes_Level = await db.Taxes_Level.FindAsync(id);
            if (taxes_Level == null)
            {
                return NotFound();
            }

            db.Taxes_Level.Remove(taxes_Level);
            await db.SaveChangesAsync();

            return Ok(taxes_Level);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Taxes_LevelExists(int id)
        {
            return db.Taxes_Level.Count(e => e.IdTax_Level == id) > 0;
        }
    }
}