using AutoMapper;
using DTO;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace zirChemed
{
    public class AutoMapping: Profile
    {
        public AutoMapping()
        {
            CreateMap<ClinicVisits, ClinicVisitsDTO> ();
            CreateMap<ClinicVisitsDTO, ClinicVisits>();
            CreateMap<Employees, EmployeesDTO>();
            CreateMap<EmployeesDTO, Employees>();
            CreateMap<Insemination, InseminationDTO>();
            CreateMap<InseminationDTO, Insemination>();
            CreateMap<Iui, IuiDTO>();
            CreateMap<IuiDTO, Iui>();
            CreateMap<Pct, PctDTO>();
            CreateMap<PctDTO, Pct>();
            CreateMap<Persons, PersonsDTO>();
            CreateMap<PersonsDTO, Persons>();
            CreateMap<Sa, SaDTO>();
            CreateMap<SaDTO, Sa>();
            CreateMap<Subsidization, SubsidizationDTO>();
            CreateMap<SubsidizationDTO, Subsidization>();
            CreateMap<Treatments, TreatmentsDTO>();
            CreateMap<TreatmentsDTO, Treatments>();
          

        }
    }
}
