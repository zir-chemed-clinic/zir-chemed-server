
using AutoMapper;
using DL;
using DTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public class ClinicVisitsBl:IClinicVisitsBl
    {
        IMapper _mapper;
        IClinicVisitsDl _IClinicVisitsDl;
        public ClinicVisitsBl(IMapper mapper,IClinicVisitsDl iClinicVisitsDl)
        {
            _mapper = mapper;
            _IClinicVisitsDl = iClinicVisitsDl;
        }
        public async Task<ClinicVisitsDTO> add(ClinicVisitsDTO clinicVisitsDTO)
        {
            ClinicVisits clinicVisits = _mapper.Map<ClinicVisits>(clinicVisitsDTO);
            ClinicVisits clinicVisitsAfterAdd = await _IClinicVisitsDl.add(clinicVisits);
            ClinicVisitsDTO clinicVisitsDTOToReturn = _mapper.Map<ClinicVisitsDTO>(clinicVisitsAfterAdd);
            return clinicVisitsDTOToReturn;
        }

        public async Task<ClinicVisitsDTO> delete(int idClinicVisitsDTO)
        {
            ClinicVisits clinicVisitsAfterDelete = await _IClinicVisitsDl.delete(idClinicVisitsDTO);
            ClinicVisitsDTO clinicVisitsDTOToReturn = _mapper.Map<ClinicVisitsDTO>(clinicVisitsAfterDelete);
            return clinicVisitsDTOToReturn;
        }
        public async Task<ClinicVisitsDTO> editStatus(int idClinicVisitsDTO)
        {
            ClinicVisits clinicVisitsAfterDelete = await _IClinicVisitsDl.editStatus(idClinicVisitsDTO);
            ClinicVisitsDTO clinicVisitsDTOToReturn = _mapper.Map<ClinicVisitsDTO>(clinicVisitsAfterDelete);
            return clinicVisitsDTOToReturn;
        }

        public async Task<ClinicVisitsDTO> edit(ClinicVisitsDTO clinicVisitsDTO)
        {
            ClinicVisits clinicVisits = _mapper.Map<ClinicVisits>(clinicVisitsDTO);
            ClinicVisits clinicVisitsAfterEdit = await _IClinicVisitsDl.edit(clinicVisits);
            ClinicVisitsDTO clinicVisitsDTOToReturn = _mapper.Map<ClinicVisitsDTO>(clinicVisitsAfterEdit);
            return clinicVisitsDTOToReturn;
        }

        public async Task<List<ClinicVisitsDTO>> getAll()
        {
            List<ClinicVisits> allClinicVisits = await _IClinicVisitsDl.getAll();
            List<ClinicVisitsDTO> allClinicVisitsDTOToReturn = _mapper.Map<List<ClinicVisits>, List<ClinicVisitsDTO>>(allClinicVisits);
            return allClinicVisitsDTOToReturn;
        }

        public async Task<List<ClinicVisitsDTO>> getByDate(DateTime date1, DateTime date2)
        {
            List<ClinicVisits> allClinicVisits = await _IClinicVisitsDl.getByDate(date1, date2);
            List<ClinicVisitsDTO> allClinicVisitsDTOToReturn = _mapper.Map<List<ClinicVisits>, List<ClinicVisitsDTO>>(allClinicVisits);
            return allClinicVisitsDTOToReturn;
        }

        public async Task<List<ClinicVisitsDTO>> getByemployeesIdAndDate(int employeesId, DateTime date1, DateTime date2)
        {
            List<ClinicVisits> allClinicVisits = await _IClinicVisitsDl.getByemployeesIdAndDate(employeesId, date1, date2);
            List<ClinicVisitsDTO> allClinicVisitsDTOToReturn = _mapper.Map<List<ClinicVisits>, List<ClinicVisitsDTO>>(allClinicVisits);
            return allClinicVisitsDTOToReturn;
        }

        public async Task<List<ClinicVisitsDTO>> getByFlag(bool flag)
        {
            List<ClinicVisits> allClinicVisits = await _IClinicVisitsDl.getByFlag(flag);
            List<ClinicVisitsDTO> allClinicVisitsDTOToReturn = _mapper.Map<List<ClinicVisits>, List<ClinicVisitsDTO>>(allClinicVisits);
            return allClinicVisitsDTOToReturn;
        }

        //public async Task<List<ClinicVisits>> getAll()
        //{
        //    List<ClinicVisits> allClinicVisits = await _IClinicVisitsDl.getAll();

        //    return allClinicVisits;
        //}

        public async Task<ClinicVisitsDTO> getById(int idClinicVisitsDTO)
        {
            ClinicVisits clinicVisits = await _IClinicVisitsDl.getById(idClinicVisitsDTO);
            ClinicVisitsDTO clinicVisitsDTOToReturn = _mapper.Map<ClinicVisitsDTO>(clinicVisits);
            return clinicVisitsDTOToReturn;
        }
        public async Task<ClinicVisitsDTO> add(int idClinicVisitsDTO)
        {
            ClinicVisits clinicVisitsAfterDelete = await _IClinicVisitsDl.delete(idClinicVisitsDTO);
            ClinicVisitsDTO clinicVisitsDTOToReturn = _mapper.Map<ClinicVisitsDTO>(clinicVisitsAfterDelete);
            return clinicVisitsDTOToReturn;
        }
    }
}