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
    public partial class Suppliers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Suppliers()
        {
            this.Products = new HashSet<Products>();
            this.Supply = new HashSet<Supply>();
        }
        [DataMember]
        public int IdSupplier { get; set; }
        [DataMember]
        public string Name_Supplier { get; set; }
        [DataMember]
        public Nullable<int> IdAddress { get; set; }
        [DataMember]
        public Nullable<int> IdContact { get; set; }

        [DataMember]
        public virtual Addresses Addresses { get; set; }
        [DataMember]
        public virtual Contacts Contacts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        [DataMember]
        public virtual ICollection<Products> Products { get; set; }
        [DataMember]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Supply> Supply { get; set; }
    }
}
