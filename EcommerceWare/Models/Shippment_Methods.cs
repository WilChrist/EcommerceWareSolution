//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EcommerceWare.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shippment_Methods
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shippment_Methods()
        {
            this.Orders = new HashSet<Orders>();
        }
    
        public int IdShippment_Method { get; set; }
        public string Name_Shippment_Method { get; set; }
        public string Description_Shippment_Method { get; set; }
        public decimal Price_Shippment_Method { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Orders> Orders { get; set; }
    }
}
