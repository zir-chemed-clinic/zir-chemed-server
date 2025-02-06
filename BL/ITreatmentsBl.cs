using DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface ITreatmentsBl
    {
        Task<TreatmentsDTO> getById(int idTreatmentsDTO);
        Task<List<TreatmentsDTO>> getAll();
        Task<TreatmentsDTO> add(TreatmentsDTO treatmentsDTO);
        Task<TreatmentsDTO> edit(TreatmentsDTO treatmentsDTO);
        Task<TreatmentsDTO> delete(int idTreatmentsDTO);
    }
}