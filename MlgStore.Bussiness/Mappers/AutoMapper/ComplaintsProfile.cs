using AutoMapper;
using MlgStore.Model.Dtos;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Bussiness.Mappers.AutoMapper
{
	public class ComplaintsProfile : Profile
	{
        public ComplaintsProfile()
        {
			CreateMap<Complaints, ComplaintsGetDto>();

			CreateMap<SendComplaintsDto, Complaints>();


		}


    }
}
