using Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public class EmployeesDl:IEmployeesDl
    {
        zirChemedContext _zirChemedContext;
        public EmployeesDl(zirChemedContext zirChemedContext)
        {
            _zirChemedContext = zirChemedContext;
        }

        public async Task<Employees> add(Employees employees)
        {
            if (employees.EmployeeId != 0)
            {
                _zirChemedContext.Employees.Update(employees);
                await _zirChemedContext.SaveChangesAsync();
                return employees;
            }
            await _zirChemedContext.Employees.AddAsync(employees);
            await _zirChemedContext.SaveChangesAsync();
            return employees;
        }

        public async Task<Employees> delete(int idEmployees)
        {
            Employees employeesToRemove = await _zirChemedContext.Employees.FirstOrDefaultAsync(c => c.EmployeeId == idEmployees);
            _zirChemedContext.Employees.Remove(employeesToRemove);
            await _zirChemedContext.SaveChangesAsync();
            return employeesToRemove;
        }

        public async Task<Employees> edit(Employees employees)
        {
            _zirChemedContext.Employees.Update(employees);
            await _zirChemedContext.SaveChangesAsync();
            return employees;
        }

        public async Task<List<Employees>> getAll()
        {
            return await _zirChemedContext.Employees.ToListAsync();
        }

        public async Task<Employees> getById(int idEmployees)
        {
            return await _zirChemedContext.Employees
                 .FirstOrDefaultAsync(c => c.EmployeeId == idEmployees);
        }
    }
}