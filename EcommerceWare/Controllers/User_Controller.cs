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
using EcommerceWare;

namespace EcommerceWare.Controllers
{
    public class User_Controller : ApiController
    {
        private ASP_ecommerceEntities1 db = new ASP_ecommerceEntities1();

        // GET: api/User_
        public IQueryable<User_> GetUser_()
        {
            return db.User_;
        }

        // GET: api/User_/5
        [ResponseType(typeof(User_))]
        public async Task<IHttpActionResult> GetUser_(string id)
        {
            User_ user_ = await db.User_.FindAsync(id);
            if (user_ == null)
            {
                return NotFound();
            }

            return Ok(user_);
        }

        // PUT: api/User_/5
        [ResponseType(typeof(void))]
        public async Task<IHttpActionResult> PutUser_(string id, User_ user_)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != user_.email)
            {
                return BadRequest();
            }

            db.Entry(user_).State = EntityState.Modified;

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!User_Exists(id))
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

        // POST: api/User_
        [ResponseType(typeof(User_))]
        public async Task<IHttpActionResult> PostUser_(User_ user_)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.User_.Add(user_);

            try
            {
                await db.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (User_Exists(user_.email))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = user_.email }, user_);
        }

        // DELETE: api/User_/5
        [ResponseType(typeof(User_))]
        public async Task<IHttpActionResult> DeleteUser_(string id)
        {
            User_ user_ = await db.User_.FindAsync(id);
            if (user_ == null)
            {
                return NotFound();
            }

            db.User_.Remove(user_);
            await db.SaveChangesAsync();

            return Ok(user_);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool User_Exists(string id)
        {
            return db.User_.Count(e => e.email == id) > 0;
        }
    }
}