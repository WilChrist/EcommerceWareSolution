using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using EcommerceWare.API.Models;

namespace EcommerceWare.API.Controllers
{
    public class CategoriesController : ApiController
    {
        IViewService s;
        public CategoriesController()
        {
            s = new ViewServiceImp();
        }
        // GET: api/Categories
        public IEnumerable<CategoriesForView> Get()
        {
            return s.GetCategoriesForView();
        }

        // GET: api/Categories/5
        public CategoriesForView Get(int id)
        {
            return s.GetCategorieForView(id);
        }

    }
}
