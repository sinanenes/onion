using AutoMapper;
using DHMOnline.Domain.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Infrastructure.AutoMapper
{
    public static class MapperProfile
    {
        public static MapperConfiguration InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapperProfile());

            });

            return config;
        }
    }
}
