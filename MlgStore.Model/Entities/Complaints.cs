using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Entities
{
    public class Complaints
    {
        public int Id { get; set; }
        public string Title { get; set; }    
        public int? CustomerID { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
