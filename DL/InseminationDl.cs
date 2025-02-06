using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public class InseminationDl:IInseminationDl
    {
        zirChemedContext _zirChemedContext;
        public InseminationDl(zirChemedContext zirChemedContext)
        {
            _zirChemedContext = zirChemedContext;
        }

        public async Task<Insemination> add(Insemination insemination)
        {
            if (insemination.InseminationId != 0)
            {
                _zirChemedContext.Insemination.Update(insemination);
                await _zirChemedContext.SaveChangesAsync();
                return insemination;
            }
            await _zirChemedContext.Insemination.AddAsync(insemination);
            await _zirChemedContext.SaveChangesAsync();
            return insemination;
        }

        public async Task<Insemination> delete(int idInsemination)
        {
            Insemination inseminationToRemove = await _zirChemedContext.Insemination
                .FirstOrDefaultAsync(c => c.InseminationId == idInsemination);
            _zirChemedContext.Insemination.Remove(inseminationToRemove);
            await _zirChemedContext.SaveChangesAsync();
            return inseminationToRemove;
        }

        public async Task<Insemination> edit(Insemination insemination)
        {
            _zirChemedContext.Insemination.Update(insemination);
            await _zirChemedContext.SaveChangesAsync();
            return insemination;
        }

        public async Task<List<Insemination>> getAll()
        {
            return await _zirChemedContext.Insemination.ToListAsync();
        }

        public async Task<Insemination> getById(int idInsemination)
        {
            return await _zirChemedContext.Insemination
                 .FirstOrDefaultAsync(c => c.ClinicVisitsId == idInsemination);
        }
    }
}