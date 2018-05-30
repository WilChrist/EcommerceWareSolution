//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcommerceWareAPI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            this.Order_Details = new HashSet<Order_Details>();
            this.Reclamations = new HashSet<Reclamation>();
            this.Returns = new HashSet<Return>();
        }
    
        public int IdOrder { get; set; }
        public int IdCustomer { get; set; }
        public Nullable<int> IdEmployee { get; set; }
        public Nullable<int> IdStatus_Order { get; set; }
        public Nullable<int> IdPayment_Method { get; set; }
        public Nullable<int> IdShippment_Method { get; set; }
        public string Description_Order { get; set; }
        public Nullable<System.DateTime> Date_Order { get; set; }
        public Nullable<System.DateTime> Date_Shippment { get; set; }
        public int Orders_Discount_Percent { get; set; }
        public Nullable<decimal> Amount_Order { get; set; }
    
        public virtual Customer Customer { get; set; }
        public virtual Employee Employee { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Details> Order_Details { get; set; }
        public virtual Payment_Methods Payment_Methods { get; set; }
        public virtual Shippment_Methods Shippment_Methods { get; set; }
        public virtual Status_Orders Status_Orders { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reclamation> Reclamations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Return> Returns { get; set; }
    }
}
