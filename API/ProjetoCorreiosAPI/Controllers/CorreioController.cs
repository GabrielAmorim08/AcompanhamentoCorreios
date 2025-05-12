using Microsoft.AspNetCore.Mvc;
using ProjetoCorreiosAPI.Interface;
using ProjetoCorreiosAPI.VO;

namespace ProjetoCorreiosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CorreioController : ControllerBase
    {
        protected readonly ICorreio _bussines;
        public CorreioController(ICorreio business) { _bussines = business; }
        [HttpGet(Name ="GetToken")]
        public Task<ReturnVO<AuthVO>> GetToken() => _bussines.GetToken();
    }
}
