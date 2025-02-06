using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public class SaDl:ISaDl
    {
        zirChemedContext _zirChemedContext;
        public SaDl(zirChemedContext zirChemedContext)
        {
            _zirChemedContext = zirChemedContext;
        }

        public async Task<Sa> add(Sa sa)
        {
            if (sa.Said != 0)
            {
                _zirChemedContext.Sa.Update(sa);
                await _zirChemedContext.SaveChangesAsync();
                return sa;
            }
            await _zirChemedContext.Sa.AddAsync(sa);
            await _zirChemedContext.SaveChangesAsync();
            return sa;
        }

        public async Task<Sa> delete(int idSa)
        {
            Sa saToRemove = await _zirChemedContext.Sa
                .FirstOrDefaultAsync(c => c.Said == idSa);
            _zirChemedContext.Sa.Remove(saToRemove);
            await _zirChemedContext.SaveChangesAsync();
            return saToRemove;
        }

        public async Task<Sa> edit(Sa sa)
        {
            _zirChemedContext.Sa.Update(sa);
            await _zirChemedContext.SaveChangesAsync();
            return sa;
        }

        public async Task<List<Sa>> getAll()
        {
            return await _zirChemedContext.Sa.ToListAsync();
        }

        public async Task<Sa> getById(int saId)
        {
            return await _zirChemedContext.Sa
                 .FirstOrDefaultAsync(c => c.ClinicVisitsId == saId);
        }

    }
}