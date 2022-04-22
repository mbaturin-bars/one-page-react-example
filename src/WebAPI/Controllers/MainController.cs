using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public MainController(IConfiguration configuration) => _configuration = configuration;

        /// <summary>
        /// Получить рандомный GUID в строковом формате.
        /// </summary>
        [HttpGet]
        [Route("/GetSomeGuid")]
        public IActionResult GetSomeGuid() => new JsonResult(Guid.NewGuid().ToString());

        /// <summary>
        /// Получить значение конфигурации по ключу.
        /// </summary>
        [HttpGet]
        [Route("/GetConfigValue")]
        public IActionResult GetConfigValue(string key) => new JsonResult(_configuration[key] ?? "Not founded");
    }
}