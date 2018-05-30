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
    public class Status_ReclamationController : ApiController
    {
        private ecommerceEntities db = new ecommerceEntities();

        // GET: api/Status_Reclamation
        public IQueryable<Status_Reclamation> GetStatus_Reclamation()
        {
            return db.Status_Reclamation;
        }

        // GET: api/Status_Reclamation/5
        [ResponseType(typeof(Status_Reclamation))]
        public async Task<IHttpActionResult> GetStatus_Reclamation(int id)
        {
            Status_Reclamation status_Reclamation = await db.Status_Reclamation.FindAsync(id);
            if (status_Reclamation == null)
            {
                return NotFound();
            }

            return Ok(status_Reclamation);
        }

        // PUT: api/Status_Reclamation/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutStatus_Reclamation(int id, Status_Reclamation status_Reclamation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != status_Reclamation.IdStatus_Reclamation)
            {
                return BadRequest();
            }

            db.Entry(status_Reclamation).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Status_ReclamationExists(id))
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

        // POST: api/Status_Reclamation
        [ResponseType(typeof(Status_Reclamation))]
        public async Task<IHttpActionResult> PostStatus_Reclamation(Status_Reclamation status_Reclamation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Status_Reclamation.Add(status_Reclamation);
            await db.SaveChangesAsync();

            return CreatedAtRoute("DefaultApi", new { id = status_Reclamation.IdStatus_Reclamation }, status_Reclamation);
        }

        // DELETE: api/Status_Reclamation/5
        [ResponseType(typeof(Status_Reclamation))]
        public async Task<IHttpActionResult> DeleteStatus_Reclamation(int id)
        {
            Status_Reclamation status_Reclamation = await db.Status_Reclamation.FindAsync(id);
            if (status_Reclamation == null)
            {
                return NotFound();
            }

            db.Status_Reclamation.Remove(status_Reclamation);
            await db.SaveChangesAsync();

            return Ok(status_Reclamation);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Status_ReclamationExists(int id)
        {
            return db.Status_Reclamation.Count(e => e.IdStatus_Reclamation == id) > 0;
        }
    }
}