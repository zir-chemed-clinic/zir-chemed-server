using AutoMapper;
using DL;
using DTO;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public class InseminationBl:IInseminationBl
    {
        IMapper _mapper;
        IInseminationDl _IInseminationDl;
        public InseminationBl(IMapper mapper, IInseminationDl iInseminationDl)
        {
            _mapper = mapper;
            _IInseminationDl = iInseminationDl;
        }
        public async Task<InseminationDTO> add(InseminationDTO inseminationDTO)
        {
            Insemination insemination = _mapper.Map<Insemination>(inseminationDTO);
            Insemination inseminationAfterAdd = await _IInseminationDl.add(insemination);
            InseminationDTO inseminationDTOToReturn = _mapper.Map<InseminationDTO>(inseminationAfterAdd);
            return inseminationDTOToReturn;
        }

        public async Task<InseminationDTO> delete(int idInseminationDTO)
        {
            Insemination inseminationAfterDelete = await _IInseminationDl.delete(idInseminationDTO);
            InseminationDTO inseminationDTOToReturn = _mapper.Map<InseminationDTO>(inseminationAfterDelete);
            return inseminationDTOToReturn;
        }

        public async Task<InseminationDTO> edit(InseminationDTO inseminationDTO)
        {
            Insemination insemination = _mapper.Map<Insemination>(inseminationDTO);
            Insemination inseminationAfterEdit = await _IInseminationDl.edit(insemination);
            InseminationDTO inseminationDTOToReturn = _mapper.Map<InseminationDTO>(inseminationAfterEdit);
            return inseminationDTOToReturn;
        }

        public async Task<List<InseminationDTO>> getAll()
        {
            List<Insemination> allInsemination = await _IInseminationDl.getAll();
            List<InseminationDTO> allInseminationDTOToReturn = _mapper.Map<List<Insemination>, List<InseminationDTO>>(allInsemination);
            return allInseminationDTOToReturn;
        }

        public async Task<InseminationDTO> getById(int idInseminationDTO)
        {
            Insemination insemination = await _IInseminationDl.getById(idInseminationDTO);
            InseminationDTO inseminationDTOToReturn = _mapper.Map<InseminationDTO>(insemination);
            return inseminationDTOToReturn;
        }
    }
}