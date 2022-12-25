using DHMOnline.Domain.Dtos;
using DHMOnline.Domain.Entities;
using DHMOnline.Domain.Interfaces.Base;
using DHMOnline.Domain.Items;
using DHMOnline.Infrastructure.AutoMapper;
using DHMOnline.Services.Interfaces;
using DHMOnline.Services.Services.Base;

namespace DHMOnline.Services.Services
{
    public class UserService : ServiceBase, IUserService<UserDto>
    {
        public UserService(IUnitOfWork unitOfWork, IDHMMapper mapper) : base(unitOfWork, mapper)
        {

        }

        public async Task<UserDto> AddAsync(UserDto dto)
        {
            var entity = _mapper.Map<User>(dto);

            entity = await _unitOfWork.UserRepository.AddAsync(entity);

            //var commit = _unitOfWork.CommitChangesAsync();
            var commit = _unitOfWork.CommitPersonelDBChangesAsync();

            //dto.Id = entity.Id;

            return dto;
        }

        public async Task<ICollection<UserDto>> GetAllAsync()
        {
            var res = await _unitOfWork.UserRepository.GetAllAsync();
            var resDtos = _mapper.Map<ICollection<UserDto>>(res);

            return resDtos;
        }

        public async Task<bool> IsValidUserLoginAsync(LoginRequestItem loginRequestItem)
        {
            //httpContext headerdan tokeni oku
            //tokenin icinden user id, claims vs alinir
            //logservice.log("","","")
            //ayrica attribute yontemi ile [Logla("")] vs gibi loglanabilir
            //ayrica middleware ile de loglama yapilabilir
            return await _unitOfWork.UserRepository.IsValidUserLogin(loginRequestItem.UserName, loginRequestItem.Password);
        }
    }
}
