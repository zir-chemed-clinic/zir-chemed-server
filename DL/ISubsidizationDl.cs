using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface ISubsidizationDl
    {
        Task<Subsidization> add(Subsidization subsidization);
        Task<Subsidization> delete(int idSubsidizationDTO);
        Task<Subsidization> edit(Subsidization subsidization);
        Task<List<Subsidization>> getAll();
        Task<Subsidization> getById(int idSubsidizationDTO);
    }
}