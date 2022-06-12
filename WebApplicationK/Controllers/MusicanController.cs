using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using WebApplicationK.Services;

namespace WebApplicationK.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicanController : ControllerBase
    {
        private readonly IDbService _dbService;

        public MusicanController(IDbService dbService)
        {
            _dbService = dbService;
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetMusicians()
    {
        var musicans = await _dbService.GetMusicians();
        return Ok(musicans);
    }
}
