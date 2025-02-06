using Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IIuiDl
    {
        Task<Iui> add(Iui iui);
        Task<Iui> delete(int idIuiDTO);
        Task<Iui> edit(Iui iui);
        Task<List<Iui>> getAll();
        Task<Iui> getById(int idIuiDTO);
    }
}