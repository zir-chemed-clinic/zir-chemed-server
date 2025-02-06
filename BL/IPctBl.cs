using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IPctBl
    {
        Task<PctDTO> getById(int idPctDTO);
        Task<List<PctDTO>> getAll();
        Task<PctDTO> add(PctDTO pctDTO);
        Task<PctDTO> edit(PctDTO pctDTO);
        Task<PctDTO> delete(int idPctDTO);
    }
}