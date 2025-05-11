using ProjetoCorreiosAPI.Interface;
using ProjetoCorreiosAPI.Model;

namespace ProjetoCorreiosAPI.Bussines
{
    public class CorreioBO : ICorreio
    {
        protected readonly DbCorreiosContext _context;
        public CorreioBO(DbCorreiosContext context) { _context = context; }
        public string GetToken()
        {
            throw new NotImplementedException();
        }
    }
}
