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
    public class ReclamationsController : ApiController
    {
        private ecommerceEntities db = new ecommerceEntities();

        // GET: api/Reclamations
        public IQueryable<Reclamation> GetReclamations()
        {
            return db.Reclamations;
        }

        // GET: api/Reclamations/5
        [ResponseType(typeof(Reclamation))]
        public async Task<IHttpActionResult> GetReclamation(int id)
        {
            Reclamation reclamation = await db.Reclamations.FindAsync(id);
            if (reclamation == null)
            {
                return NotFound();
            }

            return Ok(reclamation);
        }

        // PUT: api/Reclamations/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutReclamation(int id, Reclamation reclamation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != reclamation.IdReclamation)
            {
                return BadRequest();
            }

            db.Entry(reclamation).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ReclamationExists(id))
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

        // POST: api/Reclamations
        [ResponseType(typeof(Reclamation))]
        public async Task<IHttpActionResult> PostReclamation(Reclamation reclamation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Reclamations.Add(reclamation);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = reclamation.IdReclamation }, reclamation);
        }

        // DELETE: api/Reclamations/5
        [ResponseType(typeof(Reclamation))]
        public async Task<IHttpActionResult> DeleteReclamation(int id)
        {
            Reclamation reclamation = await db.Reclamations.FindAsync(id);
            if (reclamation == null)
            {
                return NotFound();
            }

            db.Reclamations.Remove(reclamation);
            await db.SaveChangesAsync();

            return Ok(reclamation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ReclamationExists(int id)
        {
            return db.Reclamations.Count(e => e.IdReclamation == id) > 0;
        }
    }
}