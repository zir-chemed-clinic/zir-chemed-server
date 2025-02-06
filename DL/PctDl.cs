using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public class PctDl:IPctDl
    {
        zirChemedContext _zirChemedContext;
        public PctDl(zirChemedContext zirChemedContext)
        {
            _zirChemedContext = zirChemedContext;
        }

        public async Task<Pct> add(Pct pct)
        {
            if (pct.Pctid != 0)
            {
                _zirChemedContext.Pct.Update(pct);
                await _zirChemedContext.SaveChangesAsync();
                return pct;
            }
            await _zirChemedContext.Pct.AddAsync(pct);
            await _zirChemedContext.SaveChangesAsync();
            return pct;
        }

        public async Task<Pct> delete(int idPct)
        {
            Pct pctToRemove = await _zirChemedContext.Pct
                .FirstOrDefaultAsync(c => c.Pctid == idPct);
            _zirChemedContext.Pct.Remove(pctToRemove);
            await _zirChemedContext.SaveChangesAsync();
            return pctToRemove;
        }

        public async Task<Pct> edit(Pct pct)
        {
            _zirChemedContext.Pct.Update(pct);
            await _zirChemedContext.SaveChangesAsync();
            return pct;
        }

        public async Task<List<Pct>> getAll()
        {
            return await _zirChemedContext.Pct.ToListAsync();
        }

        public async Task<Pct> getById(int idPct)
        {
            return await _zirChemedContext.Pct
                 .FirstOrDefaultAsync(c => c.ClinicVisitsId == idPct);
        }
    }
}