using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface ISubsidizationBl
    {
        Task<SubsidizationDTO> getById(int idSubsidizationDTO);
        Task<List<SubsidizationDTO>> getAll();
        Task<SubsidizationDTO> add(SubsidizationDTO subsidizationDTO);
        Task<SubsidizationDTO> edit(SubsidizationDTO subsidizationDTO);
        Task<SubsidizationDTO> delete(int idSubsidizationDTO);
    }
}