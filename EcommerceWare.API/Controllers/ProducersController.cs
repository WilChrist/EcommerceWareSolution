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
    public class ProducersController : ApiController
    {
        private ecommerceEntities db = new ecommerceEntities();

        // GET: api/Producers
        public IQueryable<Producer> GetProducers()
        {
            return db.Producers;
        }

        // GET: api/Producers/5
        [ResponseType(typeof(Producer))]
        public IHttpActionResult GetProducer(int id)
        {
            Producer producer = db.Producers.Find(id);
            if (producer == null)
            {
                return NotFound();
            }

            return Ok(producer);
        }

        // PUT: api/Producers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProducer(int id, Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producer.IdProducer)
            {
                return BadRequest();
            }

            db.Entry(producer).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProducerExists(id))
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

        // POST: api/Producers
        [ResponseType(typeof(Producer))]
        public IHttpActionResult PostProducer(Producer producer)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Producers.Add(producer);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = producer.IdProducer }, producer);
        }

        // DELETE: api/Producers/5
        [ResponseType(typeof(Producer))]
        public IHttpActionResult DeleteProducer(int id)
        {
            Producer producer = db.Producers.Find(id);
            if (producer == null)
            {
                return NotFound();
            }

            db.Producers.Remove(producer);
            db.SaveChanges();

            return Ok(producer);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProducerExists(int id)
        {
            return db.Producers.Count(e => e.IdProducer == id) > 0;
        }
    }
}