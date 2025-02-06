using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IIuiBl
    {
        Task<IuiDTO> getById(int idIuiDTO);
        Task<List<IuiDTO>> getAll();
        Task<IuiDTO> add(IuiDTO iuiDTO);
        Task<IuiDTO> edit(IuiDTO iuiDTO);
        Task<IuiDTO> delete(int idIuiDTO);
    }
}