using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IInseminationDl
    {
        Task<Insemination> add(Insemination insemination);
        Task<Insemination> delete(int idInseminationDTO);
        Task<Insemination> edit(Insemination insemination);
        Task<List<Insemination>> getAll();
        Task<Insemination> getById(int idInseminationDTO);
    }
}