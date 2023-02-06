using AutoMapper;
using MlgStore.Model.Dtos;
using MlgStore.Model.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MlgStore.Bussiness.Mappers.AutoMapper
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<Products, ProductGetDto>()
                .ForMember(dto => dto.CategoryName, entity => entity.MapFrom(x => x.Category.CategoryName))
                .ForMember(dto => dto.Size, entity => entity.MapFrom(x => x.Size.Size))
                .ForMember(dto => dto.Color, entity => entity.MapFrom(x => x.Color.Color))
                .ForMember(dto => dto.Description, entity => entity.MapFrom(x => x.Category.Description))
                .ForMember(dto => dto.GenderType, entity => entity.MapFrom(x => x.Gender.GenderType))
                .ForMember(dto => dto.Picture, entity => entity.MapFrom(x => x.ProductPhotos.Picture));


            CreateMap<ProductForCreation, Products>();
                








        }


    }
}
