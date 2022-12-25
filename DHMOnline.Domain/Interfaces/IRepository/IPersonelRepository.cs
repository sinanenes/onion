using DHMOnline.Domain.Entities;
using DHMOnline.Domain.Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Domain.Interfaces.IRepository
{
    public interface IPersonelRepository : IGenericRepository<Personel>
    {
        // Buraya 5 methodun dışında ihtiyaca yönelik, Personele amaçlı method imzaları buraya yazılır
        // Task<string> GetPersonelByBirim(int birimId);
    }
}
