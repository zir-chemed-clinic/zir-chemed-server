using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using DTO;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zirChemed.Controllers
{
    [Route("api/[controller]")]
    public class Treatments : Controller
    {
        ITreatmentsBl _ITreatmentsBl;
        public Treatments(ITreatmentsBl ITreatmentsBl)
        {
            _ITreatmentsBl = ITreatmentsBl;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<List<TreatmentsDTO>> Get()
        {
            return await _ITreatmentsBl.getAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<TreatmentsDTO> Get(int id)
        {
            return await _ITreatmentsBl.getById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<TreatmentsDTO> Post([FromBody]TreatmentsDTO treatmentsDTO)
        {
            return await _ITreatmentsBl.add(treatmentsDTO);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<TreatmentsDTO> Put(int id, [FromBody]TreatmentsDTO treatmentsDTO)
        {
            return await _ITreatmentsBl.edit(treatmentsDTO);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<TreatmentsDTO> Delete(int id)
        {
            return await _ITreatmentsBl.delete(id);
        }
    }
}
