using DTO;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace BL
{
    public interface ISaBl
    {
        Task<SaDTO> getById(int idSaDTO);
        Task<List<SaDTO>> getAll();
        Task<SaDTO> add(SaDTO saDTO);
        Task<SaDTO> edit(SaDTO saDTO);
        Task<SaDTO> delete(int idSaDTO);
        Task<Form> sendEmail(Form saPdf);
    }
}