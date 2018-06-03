using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcommerceWare.Models
{
    [DataContract]
    public class Login_informationsForView
    {
        public Login_informationsForView() { }


        [DataMember]
        public int IdLogin_information { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}