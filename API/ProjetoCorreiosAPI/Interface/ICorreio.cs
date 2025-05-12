using System.Threading.Tasks;
using ProjetoCorreiosAPI.VO;

namespace ProjetoCorreiosAPI.Interface
{
    public interface ICorreio
    {
        public Task<ReturnVO<AuthVO>> GetToken();
    }
}
