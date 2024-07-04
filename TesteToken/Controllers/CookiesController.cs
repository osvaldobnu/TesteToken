using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using TesteToken.Services;

namespace TesteToken.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookiesController : ControllerBase
    {
        private readonly CookieService _cookieService;

        public CookiesController(CookieService cookieService)
        {
            _cookieService = cookieService;
        }

        // GET: api/<CookiesController>/logar
        [HttpGet("logar")]
        public IActionResult Logar()
        {
            _cookieService.CreateCookie(Response);
            return Ok();
        }

        // GET: api/<CookiesController>/buscaDados
        [HttpGet("buscaDados")]
        public IActionResult BuscaDados()
        {
            var token = _cookieService.GetCookie(Request);
            if (token != null)
            {
                return Ok($"Cookie value: {token}");
            }
            return NotFound("Cookie not found");
        }

        // GET: api/<CookiesController>/alteraUsuario
        [HttpGet("alteraUsuario")]
        public IActionResult AlteraUsuario()
        {
            var token = _cookieService.GetCookie(Request);
            if (token != null)
            {
                return Ok($"Cookie value: {token}");
            }
            return NotFound("Cookie not found");
        }
    }
}
