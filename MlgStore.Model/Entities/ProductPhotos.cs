using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Entities
{
    public class ProductPhotos : BaseEntity
    {
        
        public string Picture { get; set; }
        public int ProductID { get; set; }
        public Products Product { get; set; }


    }
}
