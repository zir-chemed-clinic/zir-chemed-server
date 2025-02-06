using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IUsersBL
    {
        Task<List<Users>> getAll();
        Task<Users> getById(int id);
        Task<Users> add(Users user);
        Task<Users> edit(Users user);
        Task<Users> delete(int id);
        Task<Users> getUser(string userName, string password);
    }
}