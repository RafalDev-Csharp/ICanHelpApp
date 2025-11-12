using ICanHelp.Core.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICanHelp.Core.Entities.Users
{
    public class ContactData
    {
        public Id Id { get; set; }
        public Email Email { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public StringObject Country { get; set; }
        public StringObject City { get; set; }
        public StringObject PostalCode { get; set; }
    }
}
