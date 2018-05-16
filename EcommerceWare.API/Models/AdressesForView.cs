using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcommerceWare.API.Models
{
    [DataContract]
    public class AdressesForView
    {
        public AdressesForView() { }

        public AdressesForView(Addresses ad) {
            this.IdAddress = ad.IdAddress;
            this.Country = ad.Country;
            this.City = ad.City;
            this.Zip_code = ad.Zip_code;
            this.Street_Name = ad.Street_Name;
            this.Street_Number = ad.Street_Number;
            this.State = ad.State;
        }

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