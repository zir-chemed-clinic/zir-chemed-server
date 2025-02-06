using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public class UsersDl : IUsersDl
    {
        zirChemedContext _zirChemedContext;
        public UsersDl(zirChemedContext zirChemedContext)
        {
            _zirChemedContext = zirChemedContext;
        }

        public async Task<Users> add(Users user)
        {
            if (user.UserId != 0)
            {
                _zirChemedContext.Users.Update(user);
                await _zirChemedContext.SaveChangesAsync();
                return user;
            }
            await _zirChemedContext.Users.AddAsync(user);
            await _zirChemedContext.SaveChangesAsync();
            return user;
        }

        public async Task<Users> delete(int id)
        {
            Users userToRemove = await _zirChemedContext.Users
               .FirstOrDefaultAsync(u =>u.UserId  == id);
            _zirChemedContext.Users.Remove(userToRemove);
            await _zirChemedContext.SaveChangesAsync();
            return userToRemove;
        }

        public async Task<Users> edit(Users user)
        {
            _zirChemedContext.Users.Update(user);
            await _zirChemedContext.SaveChangesAsync();
            return user;
        }

        public async Task<List<Users>> getAll()
        {
            return await _zirChemedContext.Users.ToListAsync();
        }

        public async Task<Users> getById(int id)
        {
            return await _zirChemedContext.Users
                 .FirstOrDefaultAsync(u => u.UserId == id);
        }

        public async Task<Users> getUser(string userName, string password)
        {
            return await _zirChemedContext.Users
                 .FirstOrDefaultAsync(u => u.UserName == userName && u.UserPassword== password);
        }
    }
}