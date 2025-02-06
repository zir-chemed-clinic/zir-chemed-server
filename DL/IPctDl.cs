using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IPctDl
    {
        Task<Pct> add(Pct pct);
        Task<Pct> delete(int idPctDTO);
        Task<Pct> edit(Pct pct);
        Task<List<Pct>> getAll();
        Task<Pct> getById(int idPctDTO);
    }
}