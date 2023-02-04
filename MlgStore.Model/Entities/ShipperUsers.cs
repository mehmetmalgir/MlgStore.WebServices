using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Entities
{
    public class ShipperUsers
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int ShipperID { get; set; }
        public int RoleID { get; set; }
        public Roles Roles { get; set; }
    }
}
