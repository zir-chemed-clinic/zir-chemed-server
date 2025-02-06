using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public class TreatmentsDl:ITreatmentsDl
    {
        zirChemedContext _zirChemedContext;
        public TreatmentsDl(zirChemedContext zirChemedContext)
        {
            _zirChemedContext = zirChemedContext;
        }

        public async Task<Treatments> add(Treatments treatments)
        {
            if (treatments.TreatmentId != 0)
            {
                _zirChemedContext.Treatments.Update(treatments);
                await _zirChemedContext.SaveChangesAsync();
                return treatments;
            }
            await _zirChemedContext.Treatments.AddAsync(treatments);
            await _zirChemedContext.SaveChangesAsync();
            return treatments;
        }

        public async Task<Treatments> delete(int idTreatments)
        {
            Treatments treatmentsToRemove = await _zirChemedContext.Treatments
                .FirstOrDefaultAsync(c => c.TreatmentId == idTreatments);
            _zirChemedContext.Treatments.Remove(treatmentsToRemove);
            await _zirChemedContext.SaveChangesAsync();
            return treatmentsToRemove;
        }

        public async Task<Treatments> edit(Treatments treatments)
        {
            _zirChemedContext.Treatments.Update(treatments);
            await _zirChemedContext.SaveChangesAsync();
            return treatments;
        }

        public async Task<List<Treatments>> getAll()
        {
            return await _zirChemedContext.Treatments.ToListAsync();
        }

        public async Task<Treatments> getById(int treatmentsId)
        {
            return await _zirChemedContext.Treatments
                 .FirstOrDefaultAsync(c => c.TreatmentId == treatmentsId);
        }
    }
}