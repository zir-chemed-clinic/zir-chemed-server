using AutoMapper;
using DL;
using DTO;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public class IuiBl:IIuiBl
    {
        IMapper _mapper;
        IIuiDl _IIuiDl;
        public IuiBl(IMapper mapper, IIuiDl iIuiDl)
        {
            _mapper = mapper;
            _IIuiDl = iIuiDl;
        }
        public async Task<IuiDTO> add(IuiDTO iuiDTO)
        {
            Iui iui = _mapper.Map<Iui>(iuiDTO);
            Iui iuiAfterAdd = await _IIuiDl.add(iui);
            IuiDTO iuiDTOToReturn = _mapper.Map<IuiDTO>(iuiAfterAdd);
            return iuiDTOToReturn;
        }

        public async Task<IuiDTO> delete(int idIuiDTO)
        {
            Iui iuiAfterDelete = await _IIuiDl.delete(idIuiDTO);
            IuiDTO iuiDTOToReturn = _mapper.Map<IuiDTO>(iuiAfterDelete);
            return iuiDTOToReturn;
        }

        public async Task<IuiDTO> edit(IuiDTO iuiDTO)
        {
            Iui iui = _mapper.Map<Iui>(iuiDTO);
            Iui iuiAfterEdit = await _IIuiDl.edit(iui);
            IuiDTO iuiDTOToReturn = _mapper.Map<IuiDTO>(iuiAfterEdit);
            return iuiDTOToReturn;
        }

        public async Task<List<IuiDTO>> getAll()
        {
            List<Iui> allIui = await _IIuiDl.getAll();
            List<IuiDTO> allIuiDTOToReturn = _mapper.Map<List<Iui>, List<IuiDTO>>(allIui);
            return allIuiDTOToReturn;
        }

        public async Task<IuiDTO> getById(int idIuiDTO)
        {
            Iui iui = await _IIuiDl.getById(idIuiDTO);
            IuiDTO IuiDTOToReturn = _mapper.Map<IuiDTO>(iui);
            return IuiDTOToReturn;
        }
    }
}