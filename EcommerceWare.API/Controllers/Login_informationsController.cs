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
    public class Login_informationsController : ApiController
    {
        private ecommerceEntities db = new ecommerceEntities();

        // GET: api/Login_informations
        public IQueryable<Login_informations> GetLogin_informations()
        {
            return db.Login_informations;
        }

        // GET: api/Login_informations/5
        [ResponseType(typeof(Login_informations))]
        public IHttpActionResult GetLogin_informations(int id)
        {
            Login_informations login_informations = db.Login_informations.Find(id);
            if (login_informations == null)
            {
                return NotFound();
            }

            return Ok(login_informations);
        }

        // PUT: api/Login_informations/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutLogin_informations(int id, Login_informations login_informations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != login_informations.IdLogin_information)
            {
                return BadRequest();
            }

            db.Entry(login_informations).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Login_informationsExists(id))
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

        // POST: api/Login_informations
        [ResponseType(typeof(Login_informations))]
        public IHttpActionResult PostLogin_informations(Login_informations login_informations)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Login_informations.Add(login_informations);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = login_informations.IdLogin_information }, login_informations);
        }

        // DELETE: api/Login_informations/5
        [ResponseType(typeof(Login_informations))]
        public IHttpActionResult DeleteLogin_informations(int id)
        {
            Login_informations login_informations = db.Login_informations.Find(id);
            if (login_informations == null)
            {
                return NotFound();
            }

            db.Login_informations.Remove(login_informations);
            db.SaveChanges();

            return Ok(login_informations);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Login_informationsExists(int id)
        {
            return db.Login_informations.Count(e => e.IdLogin_information == id) > 0;
        }
    }
}