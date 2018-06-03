using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EcommerceWare.API.Models
{
    public class ViewServiceImp : IViewService
    {
        ecommerceEntities db;

        public ViewServiceImp()
        {
            db = new ecommerceEntities();
        }

        public CategoriesForView GetCategorieForView(int id)
        {
            return new CategoriesForView(db.Categories.SingleOrDefault(c => c.IdCategory == id));
            //throw new NotImplementedException();
        }

        public IEnumerable<CategoriesForView> GetCategoriesForView()
        {
            List<CategoriesForView> liste = new List<CategoriesForView>();
            foreach (var c in db.Categories) liste.Add(new CategoriesForView(c));

            return liste;
            //throw new NotImplementedException();
        }

        public ProductForView GetProductForView(int id)
        {
            return new ProductForView(db.Products.SingleOrDefault(p => p.IdProduct == id));
            //throw new NotImplementedException();
        }

        public IEnumerable<ProductForView> GetProductsForView()
        {
            List<ProductForView> liste = new List<ProductForView>();
            foreach (var c in db.Products) liste.Add(new ProductForView(c));

            return liste;
            //throw new NotImplementedException();
        }
    }
}