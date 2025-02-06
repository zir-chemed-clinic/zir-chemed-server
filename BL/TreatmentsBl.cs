using AutoMapper;
using DL;
using DTO;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public class TreatmentsBl:ITreatmentsBl
    {
        IMapper _mapper;
        ITreatmentsDl _ITreatmentsDl;
        public TreatmentsBl(IMapper mapper, ITreatmentsDl iTreatmentsDl)
        {
            _mapper = mapper;
            _ITreatmentsDl = iTreatmentsDl;
        }
        public async Task<TreatmentsDTO> add(TreatmentsDTO treatmentsDTO)
        {
            Treatments treatments = _mapper.Map<Treatments>(treatmentsDTO);
            Treatments treatmentsAfterAdd = await _ITreatmentsDl.add(treatments);
            TreatmentsDTO treatmentsDTOToReturn = _mapper.Map<TreatmentsDTO>(treatmentsAfterAdd);
            return treatmentsDTOToReturn;
        }

        public async Task<TreatmentsDTO> delete(int idTreatmentsDTO)
        {
            Treatments treatmentsAfterDelete = await _ITreatmentsDl.delete(idTreatmentsDTO);
            TreatmentsDTO treatmentsDTOToReturn = _mapper.Map<TreatmentsDTO>(treatmentsAfterDelete);
            return treatmentsDTOToReturn;
        }

        public async Task<TreatmentsDTO> edit(TreatmentsDTO treatmentsDTO)
        {
            Treatments treatments = _mapper.Map<Treatments>(treatmentsDTO);
            Treatments treatmentsAfterEdit = await _ITreatmentsDl.edit(treatments);
            TreatmentsDTO treatmentsDTOToReturn = _mapper.Map<TreatmentsDTO>(treatmentsAfterEdit);
            return treatmentsDTOToReturn;
        }

        public async Task<List<TreatmentsDTO>> getAll()
        {
            List<Treatments> allTreatments = await _ITreatmentsDl.getAll();
            List<TreatmentsDTO> allTreatmentsDTOToReturn = _mapper.Map<List<Treatments>, List<TreatmentsDTO>>(allTreatments);
            return allTreatmentsDTOToReturn;
        }

        public async Task<TreatmentsDTO> getById(int idTreatmentsDTO)
        {
            Treatments treatments = await _ITreatmentsDl.getById(idTreatmentsDTO);
            TreatmentsDTO treatmentsDTOToReturn = _mapper.Map<TreatmentsDTO>(treatments);
            return treatmentsDTOToReturn;
        }

    }
}