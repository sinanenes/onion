using AutoMapper;
using DHMOnline.Domain.Dtos;
using DHMOnline.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Domain.AutoMapper
{
    public class AutoMapperProfile : Profile
    {
        // bu classda dto ve entity eşleştirme map işlemleri tanımlanır
        public AutoMapperProfile()
        {
            CreateMap<Personel, PersonelDto>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();
            // varsa diğer mapleri buraya ekliyoruz
        }
    }
}
