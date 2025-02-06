using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public class IuiDl:IIuiDl
    {
        zirChemedContext _zirChemedContext;
        public IuiDl(zirChemedContext zirChemedContext)
        {
            _zirChemedContext = zirChemedContext;
        }

        public async Task<Iui> add(Iui iui)
        {
            if (iui.Iuiid != 0)
            {
                _zirChemedContext.Iui.Update(iui);
                await _zirChemedContext.SaveChangesAsync();
                return iui;
            }
            await _zirChemedContext.Iui.AddAsync(iui);
            await _zirChemedContext.SaveChangesAsync();
            return iui;
        }

        public async Task<Iui> delete(int idIui)
        {
            Iui iuiToRemove = await _zirChemedContext.Iui
                .FirstOrDefaultAsync(c => c.Iuiid == idIui);
            _zirChemedContext.Iui.Remove(iuiToRemove);
            await _zirChemedContext.SaveChangesAsync();
            return iuiToRemove;
        }

        public async Task<Iui> edit(Iui iui)
        {
            _zirChemedContext.Iui.Update(iui);
            await _zirChemedContext.SaveChangesAsync();
            return iui;
        }

        public async Task<List<Iui>> getAll()
        {
            return await _zirChemedContext.Iui.ToListAsync();
        }

        public async Task<Iui> getById(int idIui)
        {
            return await _zirChemedContext.Iui
                 .FirstOrDefaultAsync(c => c.ClinicVisitsId == idIui);
        }

    }
}