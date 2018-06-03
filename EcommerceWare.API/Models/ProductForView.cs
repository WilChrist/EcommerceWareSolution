using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcommerceWare.API.Models
{
    [DataContract]
    public class ProductForView
    {

        public ProductForView()
        {

        }

        [DataMember]
        public int IdProduct { get; set; }
        [DataMember]
        public int IdCategory { get; set; }
        [DataMember]
        public Nullable<int> IdProducer { get; set; }
        [DataMember]
        public string Name_Product { get; set; }
        [DataMember]
        public Nullable<int> Quantity_Possessed { get; set; }
        [DataMember]
        public Nullable<decimal> Gross_Price { get; set; }
        [DataMember]
        public Nullable<int> IdSupplier { get; set; }
        [DataMember]
        public string Description_Product { get; set; }
        [DataMember]
        public Nullable<decimal> Net_Price { get; set; }
        [DataMember]
        public Nullable<int> IdTax_Level { get; set; }
        [DataMember]
        public string Image_Url { get; set; }

    }

}