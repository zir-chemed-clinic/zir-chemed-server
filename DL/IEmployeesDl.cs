using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IEmployeesDl
    {
        Task<Employees> getById(int idEmployeesDTO);
        Task<List<Employees>> getAll();
        Task<Employees> edit(Employees employees);
        Task<Employees> delete(int idEmployeesDTO);
        Task<Employees> add(Employees employees);
    }
}