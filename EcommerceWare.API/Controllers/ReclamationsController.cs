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
        public IHttpActionResult GetReclamation(int id)
        {
            Reclamation reclamation = db.Reclamations.Find(id);
            if (reclamation == null)
            {
                return NotFound();
            }

            return Ok(reclamation);
        }

        // PUT: api/Reclamations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutReclamation(int id, Reclamation reclamation)
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
                db.SaveChanges();
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
        public IHttpActionResult PostReclamation(Reclamation reclamation)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Reclamations.Add(reclamation);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = reclamation.IdReclamation }, reclamation);
        }

        // DELETE: api/Reclamations/5
        [ResponseType(typeof(Reclamation))]
        public IHttpActionResult DeleteReclamation(int id)
        {
            Reclamation reclamation = db.Reclamations.Find(id);
            if (reclamation == null)
            {
                return NotFound();
            }

            db.Reclamations.Remove(reclamation);
            db.SaveChanges();

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