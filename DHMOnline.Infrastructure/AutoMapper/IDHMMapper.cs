using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Infrastructure.AutoMapper
{
    public interface IDHMMapper
    {
        TDestination Map<TDestination>(object source);

        object Map(object source, Type sourceType, Type destinationType);
    }
}
