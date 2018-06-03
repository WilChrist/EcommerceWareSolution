using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcommerceWare.Models
{
    [DataContract]
    public class ContactsForView
    {
       

        public ContactsForView() { }

        [DataMember]
        public int IdContact { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public string Phone_Number { get; set; }
    }
}