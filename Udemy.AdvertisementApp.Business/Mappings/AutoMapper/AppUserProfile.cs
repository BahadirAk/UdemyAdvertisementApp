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
    public class AppUserProfile : Profile
    {
        public AppUserProfile()
        {
            CreateMap<AppUserListDto, AppUser>().ReverseMap();
            CreateMap<AppUserCreateDto, AppUser>().ReverseMap();
            CreateMap<AppUserUpdateDto, AppUser>().ReverseMap();
        }
    }
}
