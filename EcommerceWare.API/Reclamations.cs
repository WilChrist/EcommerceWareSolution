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
    public partial class Reclamations
    {
        [DataMember]
        public int IdReclamation { get; set; }
        [DataMember]
        public int IdOrder { get; set; }
        [DataMember]
        public Nullable<int> IdStatus_Reclamation { get; set; }
        [DataMember]
        public int IdProduct { get; set; }
        [DataMember]
        public System.DateTime Date_reclamation { get; set; }
        [DataMember]
        public string Description_Reclamation { get; set; }
        [DataMember]
        public virtual Orders Orders { get; set; }
        [DataMember]
        public virtual Products Products { get; set; }
        [DataMember]
        public virtual Status_Reclamation Status_Reclamation { get; set; }
    }
}
