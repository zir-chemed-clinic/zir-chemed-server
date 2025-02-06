using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IUsersDl
    {
        Task<Users> add(Users user);
        Task<Users> delete(int id);
        Task<Users> edit(Users user);
        Task<List<Users>> getAll();
        Task<Users> getById(int id);
        Task<Users> getUser(string userName, string password);
    }
}