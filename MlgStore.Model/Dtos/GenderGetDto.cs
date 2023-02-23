using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Dtos
{
    public class GenderGetDto : IDto
    {
        public int Id { get; set; }
        public string GenderType { get; set; }
    }
}
