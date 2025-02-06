using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace DL
{
    public class ClinicVisitsDl : IClinicVisitsDl
    {
        zirChemedContext _zirChemedContext;
        public ClinicVisitsDl(zirChemedContext zirChemedContext)
        {
            _zirChemedContext = zirChemedContext;
        }

        public async Task<ClinicVisits> add(ClinicVisits clinicVisits)
        {
            //File.WriteAllBytes(@"c:\yourfile", Convert.FromBase64String(""));
            if (clinicVisits.ClinicVisitsId != 0)
            {
                clinicVisits.Status = 1;
                _zirChemedContext.ClinicVisits.Update(clinicVisits);
                await _zirChemedContext.SaveChangesAsync();
                return clinicVisits;
            }
            await _zirChemedContext.ClinicVisits.AddAsync(clinicVisits);
            await _zirChemedContext.SaveChangesAsync();
            return clinicVisits;
        }
        public async Task<ClinicVisits> editStatus(int idClinicVisits)
        {
            ClinicVisits clinicVisitsToRemove = await _zirChemedContext.ClinicVisits.FirstOrDefaultAsync(c => c.ClinicVisitsId == idClinicVisits);
            clinicVisitsToRemove.Status = 0;
            _zirChemedContext.ClinicVisits.Update(clinicVisitsToRemove);
            _zirChemedContext.SaveChanges();
            return clinicVisitsToRemove;
        }
        public async Task<ClinicVisits> delete(int idClinicVisits)
        {
            //Sa saToRemove = await _zirChemedContext.Sa.FirstOrDefaultAsync(s => s.ClinicVisitsId == idClinicVisits);
            //if (saToRemove != null)
            //{
            //    _zirChemedContext.Sa.Remove(saToRemove);
            //    _zirChemedContext.SaveChanges();
            //}
            //Iui iuiToRemove = await _zirChemedContext.Iui.FirstOrDefaultAsync(i => i.ClinicVisitsId == idClinicVisits);
            //if (iuiToRemove != null)
            //{
            //    _zirChemedContext.Iui.Remove(iuiToRemove);
            //    _zirChemedContext.SaveChanges();
            //}
            //Pct pctToRemove = await _zirChemedContext.Pct.FirstOrDefaultAsync(p => p.ClinicVisitsId == idClinicVisits);
            //if (pctToRemove != null)
            //{
            //    _zirChemedContext.Pct.Remove(pctToRemove);
            //    _zirChemedContext.SaveChanges();
            //}
            //Insemination inseminationToRemove = await _zirChemedContext.Insemination.FirstOrDefaultAsync(i => i.ClinicVisitsId == idClinicVisits);
            //if (inseminationToRemove != null)
            //{
            //    _zirChemedContext.Insemination.Remove(inseminationToRemove);
            //    _zirChemedContext.SaveChanges();
            //}
            //Subsidization subsidizationToRemove = await _zirChemedContext.Subsidization.FirstOrDefaultAsync(s => s.ClinicVisitsId == idClinicVisits);
            //if (subsidizationToRemove != null)
            //{
            //    _zirChemedContext.Subsidization.Remove(subsidizationToRemove);
            //    _zirChemedContext.SaveChanges();

            //}

            //ClinicVisits clinicVisitsToRemove = await _zirChemedContext.ClinicVisits.FirstOrDefaultAsync(c => c.ClinicVisitsId == idClinicVisits);
            //_zirChemedContext.ClinicVisits.Remove(clinicVisitsToRemove);
            //_zirChemedContext.SaveChanges();
            //return clinicVisitsToRemove;

            ClinicVisits clinicVisitsToRemove = await _zirChemedContext.ClinicVisits.FirstOrDefaultAsync(c => c.ClinicVisitsId == idClinicVisits);
            clinicVisitsToRemove.Status = 0;
            _zirChemedContext.ClinicVisits.Update(clinicVisitsToRemove);
            _zirChemedContext.SaveChanges();
            return clinicVisitsToRemove;
        }

        public async Task<bool> deleteByPersonId(int idPersons)
        {
            //List<ClinicVisits> clinicVisitsToRemove = await _zirChemedContext.ClinicVisits.Where(c => c.PersonsId == idPersons).ToListAsync();
            // for (int i = 0; i < clinicVisitsToRemove.Count(); i++)
            // {
            //     int idClinicVisits= clinicVisitsToRemove.
            //     Sa saToRemove = await _zirChemedContext.Sa.FirstOrDefaultAsync(s => s.ClinicVisitsId == idClinicVisits);
            //     if (saToRemove != null)
            //     {
            //         _zirChemedContext.Sa.Remove(saToRemove);
            //         await _zirChemedContext.SaveChangesAsync();
            //     }
            //     Iui iuiToRemove = await _zirChemedContext.Iui.FirstOrDefaultAsync(i => i.ClinicVisitsId == idClinicVisits);
            //     if (iuiToRemove != null)
            //     {
            //         _zirChemedContext.Iui.Remove(iuiToRemove);
            //         await _zirChemedContext.SaveChangesAsync();
            //     }
            //     Pct pctToRemove = await _zirChemedContext.Pct.FirstOrDefaultAsync(p => p.ClinicVisitsId == idClinicVisits);
            //     if (pctToRemove != null)
            //     {
            //         _zirChemedContext.Pct.Remove(pctToRemove);
            //         await _zirChemedContext.SaveChangesAsync();
            //     }
            //     Insemination inseminationToRemove = await _zirChemedContext.Insemination.FirstOrDefaultAsync(i => i.ClinicVisitsId == idClinicVisits);
            //     if (inseminationToRemove != null)
            //     {
            //         _zirChemedContext.Insemination.Remove(inseminationToRemove);
            //         await _zirChemedContext.SaveChangesAsync();
            //     }
            //     Subsidization subsidizationToRemove = await _zirChemedContext.Subsidization.FirstOrDefaultAsync(s => s.ClinicVisitsId == idClinicVisits);
            //     if (subsidizationToRemove != null)
            //     {
            //         _zirChemedContext.Subsidization.Remove(subsidizationToRemove);
            //         await _zirChemedContext.SaveChangesAsync();

            //     }
            //     ClinicVisits clinicVisitsToRemove = await _zirChemedContext.ClinicVisits.FirstOrDefaultAsync(c => c.ClinicVisitsId == idClinicVisits);
            //     _zirChemedContext.ClinicVisits.Remove(clinicVisitsToRemove);
            //     await _zirChemedContext.SaveChangesAsync();
            // }
            return true;
        }

        public async Task<ClinicVisits> edit(ClinicVisits clinicVisits)
        {
            _zirChemedContext.ClinicVisits.Update(clinicVisits);
            await _zirChemedContext.SaveChangesAsync();
            return clinicVisits;
        }

        public async Task<List<ClinicVisits>> getAll()
        {
            List<ClinicVisits> clinicVisits = await _zirChemedContext.ClinicVisits.ToListAsync();
            for (int i = 0; i < clinicVisits.Count(); i++)
            {
                if (clinicVisits[i].PersonsId != 0)
                {
                    clinicVisits[i].Persons = await _zirChemedContext.Persons
                     .FirstOrDefaultAsync(p => p.PersonsId == clinicVisits[i].PersonsId);
                }
                if (clinicVisits[i].Doctor != 0)
                {
                    clinicVisits[i].DoctorNavigation = await _zirChemedContext.Employees
                     .FirstOrDefaultAsync(e => e.EmployeeId == clinicVisits[i].Doctor);
                }
                if (clinicVisits[i].Preformed != 0)
                {
                    clinicVisits[i].PreformedNavigation = await _zirChemedContext.Employees
                    .FirstOrDefaultAsync(e => e.EmployeeId == clinicVisits[i].Preformed);
                }
                if (clinicVisits[i].TreatmentsId != 0)
                {
                    clinicVisits[i].Treatments = await _zirChemedContext.Treatments
                 .FirstOrDefaultAsync(c => c.TreatmentId == clinicVisits[i].TreatmentsId);
                }

            }
            return clinicVisits;
        }

        public async Task<List<ClinicVisits>> getByDate(DateTime date1, DateTime date2)
        {
            List<ClinicVisits> clinicVisits = await _zirChemedContext.ClinicVisits
                .Where(c => c.VisitsDate >= date1 && c.VisitsDate <= date2).ToListAsync();
            for (int i = 0; i < clinicVisits.Count(); i++)
            {
                if (clinicVisits[i].PersonsId != 0)
                {
                    clinicVisits[i].Persons = await _zirChemedContext.Persons
                     .FirstOrDefaultAsync(p => p.PersonsId == clinicVisits[i].PersonsId);
                }
                if (clinicVisits[i].Doctor != 0)
                {
                    clinicVisits[i].DoctorNavigation = await _zirChemedContext.Employees
                     .FirstOrDefaultAsync(e => e.EmployeeId == clinicVisits[i].Doctor);
                }
                if (clinicVisits[i].Preformed != 0)
                {
                    clinicVisits[i].PreformedNavigation = await _zirChemedContext.Employees
                    .FirstOrDefaultAsync(e => e.EmployeeId == clinicVisits[i].Preformed);
                }
                if (clinicVisits[i].TreatmentsId != 0)
                {
                    clinicVisits[i].Treatments = await _zirChemedContext.Treatments
                 .FirstOrDefaultAsync(c => c.TreatmentId == clinicVisits[i].TreatmentsId);
                }
                if (clinicVisits[i].Morphology != null && clinicVisits[i].Morphology != 0)
                {
                    clinicVisits[i].MorphologyNavigation = await _zirChemedContext.Employees
                    .FirstOrDefaultAsync(e => e.EmployeeId == clinicVisits[i].Morphology);
                }

            }
            return clinicVisits;
        }

        public async Task<List<ClinicVisits>> getByemployeesIdAndDate(int employeesId, DateTime date1, DateTime date2)
        {
            List<ClinicVisits> clinicVisits = await _zirChemedContext.ClinicVisits
                 .Where(c => (c.Preformed == employeesId || c.Doctor == employeesId || c.Morphology == employeesId) &&
                 c.VisitsDate >= date1 && c.VisitsDate <= date2).ToListAsync();
            for (int i = 0; i < clinicVisits.Count(); i++)
            {
                if (clinicVisits[i].TreatmentsId != 0)
                {
                    clinicVisits[i].Treatments = await _zirChemedContext.Treatments
                 .FirstOrDefaultAsync(c => c.TreatmentId == clinicVisits[i].TreatmentsId);
                }
            }
            return clinicVisits;
        }

        public async Task<List<ClinicVisits>> getByFlag(bool flag)
        {
            int treatmentsIdSAIUI = 0;
            Treatments treatmentsSAIUI = await _zirChemedContext.Treatments
                    .FirstOrDefaultAsync(c => c.TreatmentName == "IUI + SA");
            if (treatmentsSAIUI != null)
            {
                treatmentsIdSAIUI = treatmentsSAIUI.TreatmentId;
            }
            if (flag == true)
            {

                List<ClinicVisits> clinicVisits = await _zirChemedContext.ClinicVisits
                   .Where(c => (c.TreatmentsId == treatmentsIdSAIUI && c.ClosedIUI == true && c.ClosedSA == true) || (c.TreatmentsId != treatmentsIdSAIUI && (c.Closed == true || c.ClosedIUI == true || c.ClosedSA == true))).ToListAsync();
                for (int i = 0; i < clinicVisits.Count(); i++)
                {
                   
                    

                        if (clinicVisits[i].PersonsId != 0)
                    {
                        clinicVisits[i].Persons = await _zirChemedContext.Persons
                         .FirstOrDefaultAsync(p => p.PersonsId == clinicVisits[i].PersonsId);
                    }
                    if (clinicVisits[i].Doctor != 0)
                    {
                        clinicVisits[i].DoctorNavigation = await _zirChemedContext.Employees
                         .FirstOrDefaultAsync(e => e.EmployeeId == clinicVisits[i].Doctor);
                    }
                    if (clinicVisits[i].Preformed != 0)
                    {
                        clinicVisits[i].PreformedNavigation = await _zirChemedContext.Employees
                        .FirstOrDefaultAsync(e => e.EmployeeId == clinicVisits[i].Preformed);
                    }
                    if (clinicVisits[i].TreatmentsId != 0)
                    {
                        clinicVisits[i].Treatments = await _zirChemedContext.Treatments
                     .FirstOrDefaultAsync(c => c.TreatmentId == clinicVisits[i].TreatmentsId);
                    }
                
                }
                
                int x = clinicVisits.Count();
                return clinicVisits;
            }
            else
            {

                List<ClinicVisits> clinicVisits = await _zirChemedContext.ClinicVisits
               .Where(c => c.Status==1& !c.Closed == null && c.ClosedIUI == null && c.ClosedSA == null ||
               (c.TreatmentsId == treatmentsIdSAIUI &&
               (((c.ClosedIUI == null || c.ClosedIUI == false) && c.ClosedSA == true) || ((c.ClosedSA == null || c.ClosedSA == false) && c.ClosedIUI == true)))).ToListAsync();
                for (int i = 0; i < clinicVisits.Count(); i++)
                {
                    if (clinicVisits[i].PersonsId != 0)
                    {
                        clinicVisits[i].Persons = await _zirChemedContext.Persons
                         .FirstOrDefaultAsync(p => p.PersonsId == clinicVisits[i].PersonsId);
                    }
                    if (clinicVisits[i].Doctor != 0)
                    {
                        clinicVisits[i].DoctorNavigation = await _zirChemedContext.Employees
                         .FirstOrDefaultAsync(e => e.EmployeeId == clinicVisits[i].Doctor);
                    }
                    if (clinicVisits[i].Preformed != 0)
                    {
                        clinicVisits[i].PreformedNavigation = await _zirChemedContext.Employees
                        .FirstOrDefaultAsync(e => e.EmployeeId == clinicVisits[i].Preformed);
                    }
                    if (clinicVisits[i].TreatmentsId != 0)
                    {
                        clinicVisits[i].Treatments = await _zirChemedContext.Treatments
                     .FirstOrDefaultAsync(c => c.TreatmentId == clinicVisits[i].TreatmentsId);
                    }

                }
                int p = clinicVisits.Count();
                return clinicVisits;
            }
        }

        public async Task<ClinicVisits> getById(int idClinicVisits)
        {
            return await _zirChemedContext.ClinicVisits
                 .FirstOrDefaultAsync(c => c.ClinicVisitsId == idClinicVisits);
        }
    }
}