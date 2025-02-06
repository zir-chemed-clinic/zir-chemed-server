using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public class PersonsDl:IPersonsDl
    {
        zirChemedContext _zirChemedContext;
        IClinicVisitsDl _ClinicVisitsDl;
        public PersonsDl(zirChemedContext zirChemedContext, IClinicVisitsDl ClinicVisitsDl)
        {
            _zirChemedContext = zirChemedContext;
            _ClinicVisitsDl = ClinicVisitsDl;
        }

        public async Task<Persons> add(Persons persons)
        {
            if (persons.PersonsId != 0)
            {
                _zirChemedContext.Persons.Update(persons);
                await _zirChemedContext.SaveChangesAsync();
                return persons;
            }
            await _zirChemedContext.Persons.AddAsync(persons);
            await _zirChemedContext.SaveChangesAsync();
            return persons;
        }

        public async Task<Persons> delete(int idPersons)
        {
            bool removeClinicVisit = await _ClinicVisitsDl.deleteByPersonId(idPersons);
            if (removeClinicVisit) { 
            Persons personsToRemove = await _zirChemedContext.Persons
                .FirstOrDefaultAsync(c => c.PersonsId == idPersons);
            _zirChemedContext.Persons.Remove(personsToRemove);
            await _zirChemedContext.SaveChangesAsync();
                return personsToRemove;
            }
            return null;
        }

        public async Task<Persons> edit(Persons persons)
        {
            _zirChemedContext.Persons.Update(persons);
            await _zirChemedContext.SaveChangesAsync();
            return persons;
        }

        public async Task<List<Persons>> getAll()
        {
            return await _zirChemedContext.Persons.ToListAsync();
        }

        public async Task<Persons> getById(int PersonsId)
        {
            return await _zirChemedContext.Persons
                 .FirstOrDefaultAsync(c => c.PersonsId == PersonsId);
        }
    }
}