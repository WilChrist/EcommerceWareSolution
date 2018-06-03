using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace EcommerceWare.API.Models
{
    [DataContract]
    public class ContactsForView
    {
        public ContactsForView(Contacts c)
        {
            this.IdContact = c.IdContact;
            this.FirstName = c.FirstName;
            this.LastName = c.LastName;
            this.Email = c.Email;
            this.Phone_Number = c.Phone_Number;
        }

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