using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface ISaDl
    {
        Task<Sa> add(Sa sa);
        Task<Sa> delete(int idSaDTO);
        Task<Sa> edit(Sa sa);
        Task<List<Sa>> getAll();
        Task<Sa> getById(int idSaDTO);
    }
}