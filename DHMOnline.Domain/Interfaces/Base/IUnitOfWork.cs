using DHMOnline.Domain.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Domain.Interfaces.Base
{
    public interface IUnitOfWork : IDisposable
    {
        //Task<int> CommitChangesAsync();
        Task<int> CommitPersonelDBChangesAsync();
        IPersonelRepository PersonelRepository { get; }
        IUserRepository UserRepository { get; }
    }
}
