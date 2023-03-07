using AutoMapper;
using MlgStore.Model.Dtos;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Bussiness.Mappers.AutoMapper
{
    public class CustomerProfile : Profile
    {
        public CustomerProfile()
        {
            CreateMap<NewCustomerDto, Customers>();

            CreateMap<Customers, CustomersGetDto>();
        }

    }
}
