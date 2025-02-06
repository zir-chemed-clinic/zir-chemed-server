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
    public class Iui : Controller
    {
        IIuiBl _IIuiBl;
        public Iui(IIuiBl IIuiBl)
        {
            _IIuiBl = IIuiBl;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<List<IuiDTO>> Get()
        {
            return await _IIuiBl.getAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<IuiDTO> Get(int id)
        {
            return await _IIuiBl.getById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<IuiDTO> Post([FromBody]IuiDTO iuiDTO)
        {
            return await _IIuiBl.add(iuiDTO);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<IuiDTO> Put(int id, [FromBody]IuiDTO iuiDTO)
        {
            return await _IIuiBl.edit(iuiDTO);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<IuiDTO> Delete(int id)
        {
            return await _IIuiBl.delete(id);
        }
    }
}
