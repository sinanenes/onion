using DHMOnline.Domain.Interfaces.Base;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DHMOnline.Web.API.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : ControllerBase
    {
        // variables
        public readonly IHttpContextAccessor _httpContextAccessor;
        public readonly IUnitOfWork _unitOfWork;

        // DI constructor
        public BaseController(IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork)
        {
            _httpContextAccessor = httpContextAccessor;
            _unitOfWork = unitOfWork;
        }
    }
}
