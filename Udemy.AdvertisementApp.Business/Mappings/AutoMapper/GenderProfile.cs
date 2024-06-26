﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Udemy.AdvertisementApp.Dtos;
using Udemy.AdvertisementApp.Entities;

namespace Udemy.AdvertisementApp.Business.Mappings.AutoMapper
{
    public class GenderProfile : Profile
    {
        public GenderProfile()
        {
            CreateMap<GenderListDto, Gender>().ReverseMap();
            CreateMap<GenderCreateDto, Gender>().ReverseMap();
            CreateMap<GenderUpdateDto, Gender>().ReverseMap();
        }
    }
}
