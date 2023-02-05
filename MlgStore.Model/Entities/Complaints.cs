using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Entities
{
    public class Complaints : BaseEntity
    {
        
        public string Title { get; set; }    
        public int? CustomerID { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
