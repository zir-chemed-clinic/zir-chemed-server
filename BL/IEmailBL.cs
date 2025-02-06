using DTO;
using System.Threading.Tasks;

namespace BL
{
    public interface IEmailBL
    {
        Task<bool> sendEmail(Form form);
    }
}