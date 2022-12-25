using DHMOnline.DataEF.Context;
using DHMOnline.DataEF.Generics;
using DHMOnline.Domain.Entities;
using DHMOnline.Domain.Interfaces.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.DataEF.Repositories
{
    public class PersonelRepository : GenericRepository<Personel>, IPersonelRepository
    {
        public PersonelRepository(PersonelDBContext context) : base(context)
        {

        }

        // ilave methodlar buraya eklenecek
    }
}
