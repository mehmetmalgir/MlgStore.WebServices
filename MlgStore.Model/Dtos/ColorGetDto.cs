using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Dtos
{
    public class ColorGetDto : IDto
    {
        public int Id { get; set; }
        public string Color { get; set; }



    }
}
