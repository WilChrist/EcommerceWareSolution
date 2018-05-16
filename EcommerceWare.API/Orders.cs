//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcommerceWare.API
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    [DataContract]
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.Order_Details = new HashSet<Order_Details>();
            this.Reclamations = new HashSet<Reclamations>();
            this.Returns = new HashSet<Returns>();
        }
        [DataMember]
        public int IdOrder { get; set; }
        [DataMember]
        public int IdCustomer { get; set; }
        [DataMember]
        public Nullable<int> IdEmployee { get; set; }
        [DataMember]
        public Nullable<int> IdStatus_Order { get; set; }
        [DataMember]
        public Nullable<int> IdPayment_Method { get; set; }
        [DataMember]
        public Nullable<int> IdShippment_Method { get; set; }
        [DataMember]
        public string Description_Order { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Date_Order { get; set; }
        [DataMember]
        public Nullable<System.DateTime> Date_Shippment { get; set; }
        [DataMember]
        public int Orders_Discount_Percent { get; set; }
        [DataMember]
        public Nullable<decimal> Amount_Order { get; set; }

        [DataMember]
        public virtual Customers Customers { get; set; }
        [DataMember]
        public virtual Employees Employees { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order_Details> Order_Details { get; set; }
        [DataMember]
        public virtual Payment_Methods Payment_Methods { get; set; }
        [DataMember]
        public virtual Shippment_Methods Shippment_Methods { get; set; }
        [DataMember]
        public virtual Status_Orders Status_Orders { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Reclamations> Reclamations { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Returns> Returns { get; set; }
    }
}