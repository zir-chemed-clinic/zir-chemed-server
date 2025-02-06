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
    public class Insemination : Controller
    {
        IInseminationBl _IInseminationBl;
        public Insemination(IInseminationBl iInseminationBl)
        {
            _IInseminationBl = iInseminationBl;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<List<InseminationDTO>> Get()
        {
            return await _IInseminationBl.getAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<InseminationDTO> Get(int id)
        {
            return await _IInseminationBl.getById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<InseminationDTO> Post([FromBody]InseminationDTO inseminationDTO)
        {
            return await _IInseminationBl.add(inseminationDTO);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<InseminationDTO> Put(int id, [FromBody]InseminationDTO inseminationDTO)
        {
            return await _IInseminationBl.edit(inseminationDTO);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<InseminationDTO> Delete(int id)
        {
            return await _IInseminationBl.delete(id);
        }
    }
}
