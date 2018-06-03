﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcommerceWare.API.Models
{   
    [DataContract]
    public class CustomersForView
    {
        public CustomersForView() { }

        public CustomersForView(Customers cu) {
            this.IdCustomer = cu.IdCustomer;
            this.IdContact = cu.IdContact;
            this.IdMainAddress = cu.IdMainAddress;
            this.IdLogin_information = this.IdLogin_information;
            this.Address = new AddressesForView(cu.Addresses);
            this.Contact = new ContactsForView(cu.Contacts);
        }

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