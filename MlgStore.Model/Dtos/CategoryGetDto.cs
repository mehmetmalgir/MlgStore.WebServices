﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Dtos
{
    public class CategoryGetDto
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }


    }
}
