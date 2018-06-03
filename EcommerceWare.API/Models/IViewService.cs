using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceWare.API.Models
{
    interface IViewService
    {
        IEnumerable<ProductForView> GetProductsForView();
        ProductForView GetProductForView(int id);
        IEnumerable<CategoriesForView> GetCategoriesForView();
        CategoriesForView GetCategorieForView(int id);
    }
}
