using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface ITreatmentsDl
    {
        Task<Treatments> add(Treatments treatments);
        Task<Treatments> delete(int idTreatmentsDTO);
        Task<Treatments> edit(Treatments treatments);
        Task<List<Treatments>> getAll();
        Task<Treatments> getById(int idTreatmentsDTO);
    }
}