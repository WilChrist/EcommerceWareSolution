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
        public ProductForView(Products p)
        {
            this.IdProduct = p.IdProduct;
            this.IdCategory = p.IdCategory;
            this.IdSupplier = p.IdSupplier;
            this.Name_Product = p.Name_Product;
            this.Image_Url = p.Image_Url;
            this.Description_Product = p.Description_Product;
            this.Gross_Price = p.Gross_Price;
            this.Net_Price = p.Net_Price;
            this.IdTax_Level = p.IdTax_Level;
            this.Quantity_Possessed = p.Quantity_Possessed;
            this.IdProducer = p.IdProducer;
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