using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zirChemed.Controllers
{
    [Route("api/[controller]")]
    public class Sa : Controller
    {
        ISaBl _ISaBl;
        public Sa(ISaBl ISaBl)
        {
            _ISaBl = ISaBl;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<List<SaDTO>> Get()
        {
            return await _ISaBl.getAll();
        }

        // GET api/<controller>/5
        // לפי הclinicVisitsId
        [HttpGet("{id}")]
        public async Task<SaDTO> Get(int id)
        {
            return await _ISaBl.getById(id);
        }

        //POST api/<controller>
        [HttpPost]
        public async Task<SaDTO> Post([FromBody]SaDTO saDTO)
        {
            return await _ISaBl.add(saDTO);
        }
        [HttpPost("{id}")]
        public async Task<Form> Post(int id, [FromBody]Form saPdf)
        {
            return await _ISaBl.sendEmail(saPdf);
            //File.WriteAllBytes(@"c:\yourfile", Convert.FromBase64String(saPdf.File));
            //Form form = new Form();
            //form.File = "hhhh";
            //Byte[] bytes = Convert.FromBase64String(saPdf.File);
            //File.WriteAllBytes("", bytes);
            //return form;
        }
      
        //[HttpPost("{id}")]
        //public async Task<string> Post(int id, [FromBody]string saPdf)
        //{
        //    return "hhh";
        //}
        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<SaDTO> Put(int id, [FromBody]SaDTO saDTO)
        {
            return await _ISaBl.edit(saDTO);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<SaDTO> Delete(int id)
        {
            return await _ISaBl.delete(id);
        }
    }
}
