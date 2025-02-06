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
    public class Pct : Controller
    {
        IPctBl _IPctBl;
        public Pct(IPctBl IPctBl)
        {
            _IPctBl = IPctBl;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<List<PctDTO>> Get()
        {
            return await _IPctBl.getAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<PctDTO> Get(int id)
        {
            return await _IPctBl.getById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<PctDTO> Post([FromBody]PctDTO pctDTO)
        {
            return await _IPctBl.add(pctDTO);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<PctDTO> Put(int id, [FromBody]PctDTO pctDTO)
        {
            return await _IPctBl.edit(pctDTO);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<PctDTO> Delete(int id)
        {
            return await _IPctBl.delete(id);
        }
    }
}
