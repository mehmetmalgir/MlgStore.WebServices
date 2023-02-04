using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Entities
{
    public class Orders
    {
        public int Id { get; set; }
        public int? CustomerID { get; set; }
        public long OrderNumber { get; set; }
        public DateTime? OrderDate { get; set; }
        public DateTime? ShipDate { get; set; }
        public int? ShipperID { get; set; }
        public decimal? Freight { get; set; }
        public decimal? Paid { get; set; }




    }
}
