using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Entities
{
    public class Customers : BaseEntity
    {
        
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string CreditCardNum { get; set; }
        public int CardExpMo { get; set; }
        public int CardExpYr { get; set; }
        public DateTime? RegistirationDate { get; set; }
        public int RoleID { get; set; }
        public Roles Roles { get; set; }

    }
}
