using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IPersonsBl
    {
        Task<PersonsDTO> getById(int idpersonsDTO);
        Task<List<PersonsDTO>> getAll();
        Task<PersonsDTO> add(PersonsDTO personsDTO);
        Task<PersonsDTO> edit(PersonsDTO personsDTO);
        Task<PersonsDTO> delete(int idpersonsDTO);
    }
}