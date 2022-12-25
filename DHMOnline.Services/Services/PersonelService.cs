using DHMOnline.Domain.Dtos;
using DHMOnline.Domain.Entities;
using DHMOnline.Domain.Interfaces.Base;
using DHMOnline.Infrastructure.AutoMapper;
using DHMOnline.Services.Interfaces;
using DHMOnline.Services.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DHMOnline.Services.Services
{
    public class PersonelService : ServiceBase, IPersonelService<PersonelDto>
    {
        public PersonelService(IUnitOfWork unitOfWork, IDHMMapper mapper) : base(unitOfWork, mapper)
        {
        }
        public async Task<ICollection<PersonelDto>> GetAllAsync()
        {
            var res = await _unitOfWork.PersonelRepository.GetAllAsync();
            var resDtos = _mapper.Map<ICollection<PersonelDto>>(res);

            return resDtos;
        }
        public async Task<PersonelDto> AddAsync(PersonelDto dto)
        {
            var entity = _mapper.Map<Personel>(dto);

            entity = await _unitOfWork.PersonelRepository.AddAsync(entity);

            //var commit = _unitOfWork.CommitChangesAsync();
            var commit = _unitOfWork.CommitPersonelDBChangesAsync();

            //dto.Id = entity.Id;

            return dto;
        }

        //public Task<bool> DeleteByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<PersonelDto> GetByIdAsync(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public Task<PersonelDto> UpdateAsync(PersonelDto dto)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
