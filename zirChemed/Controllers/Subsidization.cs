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
    public class Subsidization : Controller
    {
        ISubsidizationBl _ISubsidizationBl;
        public Subsidization(ISubsidizationBl ISubsidizationBl)
        {
            _ISubsidizationBl = ISubsidizationBl;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<List<SubsidizationDTO>> Get()
        {
            return await _ISubsidizationBl.getAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<SubsidizationDTO> Get(int id)
        {
            return await _ISubsidizationBl.getById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<SubsidizationDTO> Post([FromBody]SubsidizationDTO subsidizationDTO)
        {
            return await _ISubsidizationBl.add(subsidizationDTO);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<SubsidizationDTO> Put(int id, [FromBody]SubsidizationDTO subsidizationDTO)
        {
            return await _ISubsidizationBl.edit(subsidizationDTO);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<SubsidizationDTO> Delete(int id)
        {
            return await _ISubsidizationBl.delete(id);
        }
    }
}
