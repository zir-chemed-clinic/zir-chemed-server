using Entities;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IClinicVisitsDl
    {
        Task<ClinicVisits> add(ClinicVisits clinicVisits);
        Task<ClinicVisits> delete(int idClinicVisitsDTO);
        Task<ClinicVisits> editStatus(int idClinicVisitsDTO);

        Task<ClinicVisits> edit(ClinicVisits clinicVisits);
        Task<List<ClinicVisits>> getAll();
        Task<ClinicVisits> getById(int idClinicVisitsDTO);
        Task<List<ClinicVisits>> getByemployeesIdAndDate(int employeesId, DateTime date1, DateTime date2);
        Task<List<ClinicVisits>> getByDate(DateTime date1, DateTime date2);
        Task<List<ClinicVisits>> getByFlag(bool flag);
        Task<bool> deleteByPersonId(int idPersons);
    }
}