using Infrastructure.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Model.Dtos
{
    public class ShipperGetDto : IDto
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}
