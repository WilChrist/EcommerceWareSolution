using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcommerceWare.Models
{   
    [DataContract]
    public class CustomersForView
    {
        public CustomersForView() { }

        

        [DataMember]
        public int IdCustomer { get; set; }
        [DataMember]
        public Nullable<int> IdContact { get; set; }
        [DataMember]
        public Nullable<int> IdMainAddress { get; set; }
        [DataMember]
        public int IdLogin_information { get; set; }
        [DataMember]
        public AddressesForView Address { get; set; }
        [DataMember]
        public ContactsForView Contact { get; set; }
    }
}