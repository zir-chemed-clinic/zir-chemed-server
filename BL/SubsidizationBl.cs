using AutoMapper;
using DL;
using DTO;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public class SubsidizationBl:ISubsidizationBl
    {
        IMapper _mapper;
        ISubsidizationDl _ISubsidizationDl;
        public SubsidizationBl(IMapper mapper, ISubsidizationDl iSubsidizationDl)
        {
            _mapper = mapper;
            _ISubsidizationDl = iSubsidizationDl;
        }
        public async Task<SubsidizationDTO> add(SubsidizationDTO subsidizationDTO)
        {
            Subsidization subsidization = _mapper.Map<Subsidization>(subsidizationDTO);
            Subsidization subsidizationAfterAdd = await _ISubsidizationDl.add(subsidization);
            SubsidizationDTO subsidizationDTOToReturn = _mapper.Map<SubsidizationDTO>(subsidizationAfterAdd);
            return subsidizationDTOToReturn;
        }

        public async Task<SubsidizationDTO> delete(int idSubsidizationDTO)
        {
            Subsidization subsidizationAfterDelete = await _ISubsidizationDl.delete(idSubsidizationDTO);
            SubsidizationDTO subsidizationDTOToReturn = _mapper.Map<SubsidizationDTO>(subsidizationAfterDelete);
            return subsidizationDTOToReturn;
        }

        public async Task<SubsidizationDTO> edit(SubsidizationDTO subsidizationDTO)
        {
            Subsidization subsidization = _mapper.Map<Subsidization>(subsidizationDTO);
            Subsidization subsidizationAfterEdit = await _ISubsidizationDl.edit(subsidization);
            SubsidizationDTO subsidizationDTOToReturn = _mapper.Map<SubsidizationDTO>(subsidizationAfterEdit);
            return subsidizationDTOToReturn;
        }

        public async Task<List<SubsidizationDTO>> getAll()
        {
            List<Subsidization> allSaSubsidization = await _ISubsidizationDl.getAll();
            List<SubsidizationDTO> allSubsidizationDTOToReturn = _mapper.Map<List<Subsidization>, List<SubsidizationDTO>>(allSaSubsidization);
            return allSubsidizationDTOToReturn;
        }

        public async Task<SubsidizationDTO> getById(int idSubsidizationDTO)
        {
            Subsidization subsidization = await _ISubsidizationDl.getById(idSubsidizationDTO);
            SubsidizationDTO subsidizationDTOToReturn = _mapper.Map<SubsidizationDTO>(subsidization);
            return subsidizationDTOToReturn;
        }

    }
}