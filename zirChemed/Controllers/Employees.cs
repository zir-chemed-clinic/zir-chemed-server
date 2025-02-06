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
    public class Employees : Controller
    {
        IEmployeesBl _IEmployeesBl;
        public Employees(IEmployeesBl iEmployeesBl)
        {
            _IEmployeesBl = iEmployeesBl;
        }
        // GET: api/<controller>
        [HttpGet]
        public async Task<List<EmployeesDTO>> Get()
        {
            return await _IEmployeesBl.getAll();
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<EmployeesDTO> Get(int id)
        {
            return await _IEmployeesBl.getById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<EmployeesDTO> Post([FromBody]EmployeesDTO employeesDTO)
        {
            return await _IEmployeesBl.add(employeesDTO);
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<EmployeesDTO> Put(int id, [FromBody]EmployeesDTO employeesDTO)
        {
            return await _IEmployeesBl.edit(employeesDTO);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<EmployeesDTO> Delete(int id)
        {
            return await _IEmployeesBl.delete(id);
        }
    }
}
