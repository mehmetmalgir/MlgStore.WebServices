using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Entities
{
    public class OrderDetail : BaseEntity
    {
        
        public int? ProductID { get; set; }
        public int? OrderID { get; set; }
        public long? OrderNumber { get; set; }
        public int? Price { get; set; }
        public int? Quantity { get; set; }
        public int? Discount { get; set; }
        public int? TotalPrice { get; set; }
        public int? SizeID { get; set; }
        public int? ColorID { get; set; }
        public DateTime? ShipDate { get; set; }
        public int? GenderID { get; set; }




    }
}
