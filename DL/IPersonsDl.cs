using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IPersonsDl
    {
        Task<Persons> add(Persons persons);
        Task<Persons> delete(int idPersonsDTO);
        Task<Persons> edit(Persons persons);
        Task<List<Persons>> getAll();
        Task<Persons> getById(int idPersonsDTO);
    }
}