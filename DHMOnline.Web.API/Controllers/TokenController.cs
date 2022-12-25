using DHMOnline.Domain.Extensions;
using DHMOnline.Domain.Interfaces.Base;
using DHMOnline.Domain.Items;
using DHMOnline.Services.Interfaces;
using DHMOnline.Web.API.Controllers.Base;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DHMOnline.Web.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TokenController : BaseController
    {
        // variables
        public readonly ITokenService _tokenService;

        // DI constructor
        public TokenController(ITokenService tokenService, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork) : base(httpContextAccessor, unitOfWork)
        {
            _tokenService = tokenService;
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<string> Login(LoginRequestItem item)
        {
            var res = await _tokenService.GetTokenAsync(item);

            // eğer token alamadıysan
            if (res.IsNullOrEmpty())
            {
                string s = "Hatalı kullanıcı adı veya parola";
                return s;
            }
            else // token alabildiysen
            {
                return res;
            }
        }

        [AllowAnonymous]
        [HttpPost("TestMethod")]
        public async Task<string> TestMethod()
        {
            return await Task.FromResult("Merhaba");
        }

        [Authorize]
        [HttpPost("TestMethod2")]
        public async Task<string> TestMethod2()
        {
            return await Task.FromResult("Merhaba2");
        }
    }
}
