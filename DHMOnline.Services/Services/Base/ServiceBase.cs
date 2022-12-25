using DHMOnline.Domain.Interfaces.Base;
using DHMOnline.Infrastructure.AutoMapper;
using DHMOnline.Services.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Services.Services.Base
{
    
    public class ServiceBase : IServiceBase
    {
        public readonly IUnitOfWork _unitOfWork;
        public readonly IDHMMapper _mapper;

        public ServiceBase(IUnitOfWork unitOfWork,IDHMMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        
    }
}
