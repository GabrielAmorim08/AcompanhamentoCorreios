using Microsoft.AspNetCore.Mvc;
using ProjetoCorreiosAPI.Interface;

namespace ProjetoCorreiosAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CorreioController : ControllerBase
    {
        protected readonly ICorreio _bussines;
        public CorreioController(ICorreio business) { _bussines = business; }
        [HttpGet(Name ="GetToken")]
        public string GetToken() => _bussines.GetToken();
    }
}
