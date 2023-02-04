using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Entities
{
    public class ProductPhotos
    {
        public int Id { get; set; }
        public string Picture { get; set; }
        public int ProductID { get; set; }
        public Products Product { get; set; }


    }
}
