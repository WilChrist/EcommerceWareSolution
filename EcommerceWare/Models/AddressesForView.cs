using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcommerceWare.Models
{
    [DataContract]
    public class AddressesForView
    {
        public AddressesForView() { }


        [DataMember]
        public int IdAddress { get; set; }
        [DataMember]
        public string Country { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Zip_code { get; set; }
        [DataMember]
        public string Street_Name { get; set; }
        [DataMember]
        public int Street_Number { get; set; }
        [DataMember]
        public string State { get; set; }
    }
}