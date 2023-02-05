using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Entities
{
    public class Products : BaseEntity
    {
       
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int CategoryID { get; set; }
        public int QuantityPerUnit { get; set; }
        public int UnitPrice { get; set; }
        public int SizeID { get; set; }
        public int ColorID { get; set; }
        public int Discount { get; set; }
        public bool DiscountAvailable { get; set; }
        public bool CurrentOrder { get; set; }
        public int GenderID { get; set; }

        public Categories Categories { get; set; }

        public ProductPhotos ProductPhotos { get; set; }


    }
}
