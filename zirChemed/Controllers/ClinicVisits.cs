using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using DTO;
using Microsoft.AspNetCore.Mvc;
using Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zirChemed.Controllers
{
    [Route("api/[controller]")]
    public class ClinicVisits : Controller
    {
        IClinicVisitsBl _IclinicVisitsBl;
        public ClinicVisits(IClinicVisitsBl IclinicVisitsBl)
        {
            _IclinicVisitsBl = IclinicVisitsBl;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<List<ClinicVisitsDTO>> Get()
        {
            return await _IclinicVisitsBl.getAll();

        }
        [Route("getByFlag/{flag},{tmp}")]
        [HttpGet]
        public async Task<List<ClinicVisitsDTO>> Get(bool flag, int tmp)
        {
            return await _IclinicVisitsBl.getByFlag(flag);

        }


        //public async Task<List<Entities.ClinicVisits>> Get()
        //{

        //     List < Entities.ClinicVisits > clinicVisits=  await _IclinicVisitsBl.getAll();
        //    return clinicVisits;
        //}
        [Route("getByDates/{employeesId},{date1},{date2}")]
        [HttpGet]
        public async Task<List<ClinicVisitsDTO>> Get(int employeesId,DateTime date1, DateTime date2)
        {
            return await _IclinicVisitsBl.getByemployeesIdAndDate(employeesId, date1, date2);
        }
        //[HttpGet("{date1},{date2}")]
        //public async Task<List<ClinicVisitsDTO>> Get( DateTime date1, DateTime date2)
        //{
        //    return await _IclinicVisitsBl.getByDate( date1, date2);
        //}
        // GET api/<controller>/5
        [Route("getById/{id}")]
        [HttpGet]
        public async Task<ClinicVisitsDTO> Get(int id)
        {
            return await _IclinicVisitsBl.getById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<ClinicVisitsDTO> Post([FromBody]ClinicVisitsDTO clinicVisitsDTO)
        {
            return await _IclinicVisitsBl.add(clinicVisitsDTO);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<ClinicVisitsDTO> Put(int id, [FromBody]ClinicVisitsDTO clinicVisitsDTO)
        {
            return await _IclinicVisitsBl.edit(clinicVisitsDTO);
        }

        [HttpPut]
        public async Task<ClinicVisitsDTO> Put([FromBody] int id)
        {
            // עכשיו השרת מקבל את הערך 1 מ-body הבקשה
            return await _IclinicVisitsBl.editStatus(id);
        }


        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<ClinicVisitsDTO> Delete(int id)
        {
            return await _IclinicVisitsBl.delete(id);
        }
    }
}
