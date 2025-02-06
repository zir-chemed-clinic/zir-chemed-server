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
    public class Persons : Controller
    {
        IPersonsBl _IPersonsBl;
        public Persons(IPersonsBl IPersonsBl)
        {
            _IPersonsBl = IPersonsBl;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<List<PersonsDTO>>   Get()
        {
            return await _IPersonsBl.getAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<PersonsDTO> Get(int id)
        {
            return await _IPersonsBl.getById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<PersonsDTO> Post([FromBody]PersonsDTO personsDTO)
        {
            return await _IPersonsBl.add(personsDTO);
        }
     

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<PersonsDTO> Put(int id, [FromBody]PersonsDTO personsDTO)
        {
            return await _IPersonsBl.edit(personsDTO);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<PersonsDTO> Delete(int id)
        {
            return await _IPersonsBl.delete(id);
        }
    }
}
