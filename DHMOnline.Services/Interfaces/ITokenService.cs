using DHMOnline.Domain.Items;
using DHMOnline.Services.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Services.Interfaces
{
    public interface ITokenService : ITokenServiceBase
    {
        Task<string> GetTokenAsync(LoginRequestItem item);
    }
}
