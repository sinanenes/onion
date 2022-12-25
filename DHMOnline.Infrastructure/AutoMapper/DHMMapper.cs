using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Infrastructure.AutoMapper
{
    public class DHMMapper:IDHMMapper
    {
        private readonly IMapper _mapper;

        public DHMMapper()
        {
            _mapper = MapperProfile.InitializeAutoMapper().CreateMapper();
        }

        public TDestination Map<TDestination>(object source)
        {
            return _mapper.Map<TDestination>(source);
        }

        public object Map(object source, Type sourceType, Type destinationType)
        {
            return _mapper.Map(source, sourceType, destinationType);
        }
    }
}
