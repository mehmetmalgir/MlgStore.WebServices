﻿using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace MlgStore.Model.Dtos
{
    public class ProductGetDto : IDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int? QuantityPerUnit { get; set; }
        public int? UnitPrice { get; set; }
        public int? CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }         
        public string GenderType { get; set; }
        public int? Discount { get; set; }
        public string Picture { get; set; }





    }
}
