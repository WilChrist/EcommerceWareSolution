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
    using System.Runtime.Serialization;

    [DataContract]
    public class CategoriesForView
    {
        public CategoriesForView()
        {
            
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