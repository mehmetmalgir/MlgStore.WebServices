using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Dtos
{
    public class SizeGetDto : IDto
    {
        public int Id { get; set; }
        public string Size { get; set; }

    }
}
