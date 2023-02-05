using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Entities
{
    public class UsersAdmin : BaseEntity
    {
        
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public int RoleID { get; set; }
        public Roles Roles { get; set; }


    }
}
