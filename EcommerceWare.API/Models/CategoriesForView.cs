using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcommerceWare.API.Models
{
    [DataContract]
    public class CategoriesForView
    {
        public CategoriesForView() { }

        public CategoriesForView(Categories c)
        {
            this.IdCategory = c.IdCategory;
            this.Name_Category = c.Name_Category;
            this.Description_Category = c.Description_Category;
            this.IdParent_Category = c.IdParent_Category;
        }

        [DataMember]
        public int IdCategory { get; set; }
        [DataMember]
        public string Name_Category { get; set; }
        [DataMember]
        public string Description_Category { get; set; }
        [DataMember]
        public Nullable<int> IdParent_Category { get; set; }
    }
}