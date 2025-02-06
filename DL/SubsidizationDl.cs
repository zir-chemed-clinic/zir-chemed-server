using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public class SubsidizationDl:ISubsidizationDl
    {
        zirChemedContext _zirChemedContext;
        public SubsidizationDl(zirChemedContext zirChemedContext)
        {
            _zirChemedContext = zirChemedContext;
        }

        public async Task<Subsidization> add(Subsidization subsidization)
        {
            if (subsidization.SubsidizationId != 0)
            {
                _zirChemedContext.Subsidization.Update(subsidization);
                await _zirChemedContext.SaveChangesAsync();
                return subsidization;
            }
            await _zirChemedContext.Subsidization.AddAsync(subsidization);
            await _zirChemedContext.SaveChangesAsync();
            return subsidization;
        }

        public async Task<Subsidization> delete(int idSubsidization)
        {
            Subsidization subsidizationToRemove = await _zirChemedContext.Subsidization
                .FirstOrDefaultAsync(c => c.SubsidizationId == idSubsidization);
            _zirChemedContext.Subsidization.Remove(subsidizationToRemove);
            await _zirChemedContext.SaveChangesAsync();
            return subsidizationToRemove;
        }

        public async Task<Subsidization> edit(Subsidization subsidization)
        {
            _zirChemedContext.Subsidization.Update(subsidization);
            await _zirChemedContext.SaveChangesAsync();
            return subsidization;
        }

        public async Task<List<Subsidization>> getAll()
        {
            return await _zirChemedContext.Subsidization.ToListAsync();
        }

        public async Task<Subsidization> getById(int subsidizationId)
        {
            return await _zirChemedContext.Subsidization
                 .FirstOrDefaultAsync(c => c.SubsidizationId == subsidizationId);
        }
    }
}