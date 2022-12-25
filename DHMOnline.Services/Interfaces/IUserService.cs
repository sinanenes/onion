using DHMOnline.Domain.Items;
using DHMOnline.Services.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Services.Interfaces
{
    public interface IUserService<TDto> : IServiceBase
    {
        Task<ICollection<TDto>> GetAllAsync();
        Task<TDto> AddAsync(TDto dto);

        Task<bool> IsValidUserLoginAsync(LoginRequestItem loginRequestItem);

        //Task<TDto> GetByIdAsync(int id);
        //Task<bool> DeleteByIdAsync(int id);        
        //Task<TDto> UpdateAsync(TDto dto);
    }
}
