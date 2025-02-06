using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IEmployeesBl
    {
        Task<EmployeesDTO> getById(int idEmployeesDTO);
        Task<List<EmployeesDTO>> getAll();
        Task<EmployeesDTO> add(EmployeesDTO employeesDTO);
        Task<EmployeesDTO> edit(EmployeesDTO employeesDTO);
        Task<EmployeesDTO> delete(int idEmployeesDTO);
    }
}