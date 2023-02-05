using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Entities
{
    public class Categories : BaseEntity
    {
        
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public int TopCategory { get; set; }
        public ICollection<Products> Products { get; set; }


    }
}
