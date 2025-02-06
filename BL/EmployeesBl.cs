using AutoMapper;
using DL;
using DTO;
using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public class EmployeesBl:IEmployeesBl
    {
        IMapper _mapper;
        IEmployeesDl _IEmployeesDl;
        public EmployeesBl(IMapper mapper, IEmployeesDl iEmployeesDl)
        {
            _mapper = mapper;
            _IEmployeesDl = iEmployeesDl;
        }
        public async Task<EmployeesDTO> add(EmployeesDTO employeesDTO)
        {
            Employees employees = _mapper.Map<Employees>(employeesDTO);
            Employees employeesAfterAdd = await _IEmployeesDl.add(employees);
            EmployeesDTO employeesDTOToReturn = _mapper.Map<EmployeesDTO>(employeesAfterAdd);
            return employeesDTOToReturn;
        }

        public async Task<EmployeesDTO> delete(int idEmployeesDTO)
        {
            Employees employeesAfterDelete = await _IEmployeesDl.delete(idEmployeesDTO);
            EmployeesDTO employeesDTOToReturn = _mapper.Map<EmployeesDTO>(employeesAfterDelete);
            return employeesDTOToReturn;
        }

        public async Task<EmployeesDTO> edit(EmployeesDTO employeesDTO)
        {
            Employees employees = _mapper.Map<Employees>(employeesDTO);
            Employees employeesAfterEdit = await _IEmployeesDl.edit(employees);
            EmployeesDTO employeesDTOToReturn = _mapper.Map<EmployeesDTO>(employeesAfterEdit);
            return employeesDTOToReturn;
        }

        public async Task<List<EmployeesDTO>> getAll()
        {
            List<Employees> allEmployees = await _IEmployeesDl.getAll();
            List<EmployeesDTO> allEmployeesDTOToReturn = _mapper.Map<List<Employees>, List<EmployeesDTO>>(allEmployees);
            return allEmployeesDTOToReturn;
        }

        public async Task<EmployeesDTO> getById(int idEmployeesDTO)
        {
            Employees employees = await _IEmployeesDl.getById(idEmployeesDTO);
            EmployeesDTO employeesDTOToReturn = _mapper.Map<EmployeesDTO>(employees);
            return employeesDTOToReturn;
        }
    }
}