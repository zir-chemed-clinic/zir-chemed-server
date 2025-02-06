using DL;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public class UsersBL : IUsersBL
    {
        IUsersDl _IUserDL;
        public UsersBL(IUsersDl IUserDL)
        {
            _IUserDL = IUserDL;
        }
        public async Task<Users> add(Users user)
        {
            Users users = await _IUserDL.add(user);
          
            return users;
        }

        public async Task<Users> delete(int id)
        {
            Users user = await _IUserDL.delete(id);
            return user;
        }

        public async Task<Users> edit(Users user)
        {

            Users users = await _IUserDL.edit(user);

            return users;
        }

        public async Task<List<Users>> getAll()
        {
            List<Users> allUsers = await _IUserDL.getAll();
            return allUsers;
        }

        public async Task<Users> getById(int id)
        {
            Users user = await _IUserDL.getById(id);
            return user;
        }

        public async Task<Users> getUser(string userName, string password)
        {
            Users user = await _IUserDL.getUser(userName, password);
            return user;
        }
    }
}