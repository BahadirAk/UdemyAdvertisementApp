using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Dtos;
using Udemy.AdvertisementApp.Entities;

namespace Udemy.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class AdvertisementProfile : Profile
    {
        public AdvertisementProfile()
        {
            CreateMap<AdvertisementListDto, Advertisement>().ReverseMap();
            CreateMap<AdvertisementCreateDto, Advertisement>().ReverseMap();
            CreateMap<AdvertisementUpdateDto, Advertisement>().ReverseMap();
        }
    }
}
