using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcommerceWare.API.Models
{
    [DataContract]
    public class Login_informationsForView
    {
        public Login_informationsForView() { }

        public Login_informationsForView(Login_informations li) {
            this.IdLogin_information = li.IdLogin_information;
            this.Login = li.Login;
            this.Password = li.Password;
        }

        [DataMember]
        public int IdLogin_information { get; set; }
        [DataMember]
        public string Login { get; set; }
        [DataMember]
        public string Password { get; set; }
    }
}