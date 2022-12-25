using DHMOnline.DataEF.Context;
using DHMOnline.DataEF.Generics;
using DHMOnline.Domain.Entities;
using DHMOnline.Domain.Interfaces.IRepository;

namespace DHMOnline.DataEF.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        //variables
        private PersonelDBContext _personelDBContext;
        public UserRepository(PersonelDBContext personelDBContext) : base(personelDBContext)
        {
            _personelDBContext = personelDBContext;
        }

        //ilave methodlar buraya eklenecek...

        //IsValidUserLogin - Useri login ile kontrol eder.
        public async Task<bool> IsValidUserLogin(string sicilNo, string password)
        {
            var result = _personelDBContext.User.FirstOrDefault(x => x.UserSicilNo == sicilNo && x.UserPassword == password);
            return await Task.FromResult(result != null);
        }
    }
}
