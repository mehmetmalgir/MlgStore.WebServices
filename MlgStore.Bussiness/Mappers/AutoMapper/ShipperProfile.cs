using AutoMapper;
using MlgStore.Model.Dtos;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Bussiness.Mappers.AutoMapper
{
    public class ShipperProfile : Profile
    {
        public ShipperProfile()
        {
            CreateMap<Shippers, ShipperGetDto>();
        }




    }
}
