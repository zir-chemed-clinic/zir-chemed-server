using AutoMapper;
using DL;
using DTO;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public class PctBl:IPctBl
    {
        IMapper _mapper;
        IPctDl _IPctDl;
        public PctBl(IMapper mapper, IPctDl iPctDl)
        {
            _mapper = mapper;
            _IPctDl = iPctDl;
        }
        public async Task<PctDTO> add(PctDTO pctDTO)
        {
            Pct pct = _mapper.Map<Pct>(pctDTO);
            Pct pctAfterAdd = await _IPctDl.add(pct);
            PctDTO pctDTOToReturn = _mapper.Map<PctDTO>(pctAfterAdd);
            return pctDTOToReturn;
        }

        public async Task<PctDTO> delete(int idPctDTO)
        {
            Pct pctAfterDelete = await _IPctDl.delete(idPctDTO);
            PctDTO pctDTOToReturn = _mapper.Map<PctDTO>(pctAfterDelete);
            return pctDTOToReturn;
        }

        public async Task<PctDTO> edit(PctDTO pctDTO)
        {
            Pct pct = _mapper.Map<Pct>(pctDTO);
            Pct pctAfterEdit = await _IPctDl.edit(pct);
            PctDTO pctDTOToReturn = _mapper.Map<PctDTO>(pctAfterEdit);
            return pctDTOToReturn;
        }

        public async Task<List<PctDTO>> getAll()
        {
            List<Pct> allPct = await _IPctDl.getAll();
            List<PctDTO> allPctDTOToReturn = _mapper.Map<List<Pct>, List<PctDTO>>(allPct);
            return allPctDTOToReturn;
        }

        public async Task<PctDTO> getById(int idPctDTO)
        {
            Pct pct = await _IPctDl.getById(idPctDTO);
            PctDTO pctDTOToReturn = _mapper.Map<PctDTO>(pct);
            return pctDTOToReturn;
        }
    }
}