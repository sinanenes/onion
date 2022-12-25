using DHMOnline.Domain.Dtos;
using DHMOnline.Domain.Interfaces.Base;
using DHMOnline.Domain.Items;
using DHMOnline.Services.Interfaces;
using DHMOnline.Web.API.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DHMOnline.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseController
    {
        // variables
        public readonly IUserService<UserDto> _userService;

        // DI constructor
        public UserController(IUserService<UserDto> userService, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork) : base(httpContextAccessor, unitOfWork)
        {
            _userService = userService;

        }

        [AllowAnonymous]
        [HttpPost("GetAll")]
        public async Task<ICollection<UserDto>> GetAll()
        {
            return await _userService.GetAllAsync();
        }

        [Authorize]
        [HttpPost("Add")]
        public async Task<UserDto> Add(UserDto dto)
        {
            return await _userService.AddAsync(dto);
        }

    }
}
