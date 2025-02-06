using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IInseminationBl
    {
        Task<InseminationDTO> getById(int idInseminationDTO);
        Task<List<InseminationDTO>> getAll();
        Task<InseminationDTO> add(InseminationDTO inseminationDTO);
        Task<InseminationDTO> edit(InseminationDTO inseminationDTO);
        Task<InseminationDTO> delete(int idInseminationDTO);
        
    }
}