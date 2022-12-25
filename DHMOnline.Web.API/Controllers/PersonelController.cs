using DHMOnline.Domain.Dtos;
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
    public class PersonelController : BaseController
    {
        // variables
        public readonly IPersonelService<PersonelDto> _personelService;

        // DI constructor
        public PersonelController(IPersonelService<PersonelDto> personelService, IHttpContextAccessor httpContextAccessor, IUnitOfWork unitOfWork) : base(httpContextAccessor, unitOfWork)
        {
            _personelService = personelService;

        }        

        [AllowAnonymous]
        [HttpPost("GetAll")]
        public async Task<ICollection<PersonelDto>> GetAll()
        {
            return await _personelService.GetAllAsync();
        }

        [Authorize]
        [HttpPost("Add")]
        public async Task<PersonelDto> Add(PersonelDto dto)
        {
            return await _personelService.AddAsync(dto);
        }

        //[AllowAnonymous]
        //[HttpPost("DeleteById")]
        //public async Task<bool> DeleteById(int id)
        //{
        //    return await _personelService.DeleteByIdAsync(id);
        //}

        //[AllowAnonymous]
        //[HttpPost("GetById")]
        //public async Task<PersonelDto> GetById(int id)
        //{
        //    return await _personelService.GetByIdAsync(id);
        //}

        //[AllowAnonymous]
        //[HttpPost("Update")]
        //public async Task<PersonelDto> Update(PersonelDto dto)
        //{
        //    return await _personelService.UpdateAsync(dto);
        //}
    }
}
