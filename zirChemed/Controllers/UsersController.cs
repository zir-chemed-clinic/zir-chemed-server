using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Entities;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace zirChemed.Controllers
{
    [Route("api/[controller]")]
    public class UsersController : Controller
    {
        IUsersBL _IusersBL;
        public UsersController(IUsersBL IusersBL)
        {
            _IusersBL = IusersBL;
        }
        // GET: api/<controller>
        [Route("getAQL/{str}")]
        [HttpGet]
        public async Task<List<Users>> Get(string str)
        {
            if (str == "123456789ABCDEF")
            {
                return await _IusersBL.getAll();

            }
            else
            {
                List<Users> u = new List<Users>();
                return u;

            }
          


        }
        [HttpGet("{userName},{password}")]
        public async Task<Users> Get(string userName, string password)
        {
            return await _IusersBL.getUser(userName, password);
        }
        // GET api/<controller>/5
        [HttpGet("{id}")]
        public async Task<Users> Get(int id)
        {
            return await _IusersBL.getById(id);
        }

        // POST api/<controller>
        [HttpPost]
        public async Task<Users> Post([FromBody]Users user)
        {
            return await _IusersBL.add(user);
        }


        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public async Task<Users> Put(int id, [FromBody]Users user)
        {
            return await _IusersBL.edit(user);
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public async Task<Users> Delete(int id)
        {
            return await _IusersBL.delete(id);
        }
    }
}
