using DHMOnline.Domain.Entities;
using DHMOnline.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Domain.Interfaces.IRepository
{
    public interface IUserRepository : IGenericRepository<User>
    {
        //Sicil no ve password kullanarak boyle bir user var mi yok mu?
        Task<bool> IsValidUserLogin(string sicilNo, string password);
    }
}
