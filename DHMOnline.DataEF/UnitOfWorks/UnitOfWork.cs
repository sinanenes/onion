using DHMOnline.DataEF.Context;
using DHMOnline.DataEF.Repositories;
using DHMOnline.Domain.Interfaces.Base;
using DHMOnline.Domain.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.DataEF.UnitOfWorks
{
    //IDisposable kullanimi zorunluluk degil fakat aninda GC yi bosaltabiliriz fakat isletim sistemine bunu birakmak daha dogrudur kullanimi gormek icin ekledik
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        // variables
        private readonly PersonelDBContext _personelDBContext;
        
        // repositories
        public IPersonelRepository PersonelRepository { get; private set; }

        public IUserRepository UserRepository { get; private set; }

        // constructor
        public UnitOfWork(PersonelDBContext personelDBContext)
        {
            _personelDBContext = personelDBContext;
            PersonelRepository = new PersonelRepository(_personelDBContext);
            UserRepository = new UserRepository(_personelDBContext);
        }

        // CommitChangesAsync - Yapılan işlemleri dbye basar
        public async Task<int> CommitPersonelDBChangesAsync()
        {
            return await _personelDBContext.SaveChangesAsync();
        }

        // Dispose - contexti yok eder
        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    try
                    {
                        _personelDBContext.Dispose();                        
                    }
                    catch (Exception ex)
                    {
                    }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        
    }
}
