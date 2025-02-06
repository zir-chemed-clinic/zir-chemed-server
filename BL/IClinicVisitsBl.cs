using DTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IClinicVisitsBl
    {
        Task<ClinicVisitsDTO> getById(int idClinicVisitsDTO);
        Task<List<ClinicVisitsDTO>> getAll();
        //Task<List<ClinicVisits>> getAll();
        Task<ClinicVisitsDTO> add(ClinicVisitsDTO clinicVisitsDTO);
        Task<ClinicVisitsDTO> edit(ClinicVisitsDTO clinicVisitsDTO);
        Task<ClinicVisitsDTO> delete(int idClinicVisitsDTO);
        Task<ClinicVisitsDTO> editStatus(int idClinicVisitsDTO);
        Task<List<ClinicVisitsDTO>> getByemployeesIdAndDate(int employeesId, DateTime date1, DateTime date2);
        Task<List<ClinicVisitsDTO>> getByDate(DateTime date1, DateTime date2);
        Task<List<ClinicVisitsDTO>> getByFlag(bool flag);
    }
}