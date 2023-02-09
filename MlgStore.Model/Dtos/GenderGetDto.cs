using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Dtos
{
    public class GenderGetDto : IDto
    {
        public string GenderType { get; set; }
    }
}
