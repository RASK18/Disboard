using Disboard.Server.AniList;
using Disboard.Server.AniList.Models;
using Disboard.Server.Extensions;
using Disboard.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Disboard.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class AnimeController
    {
        private readonly AniWrapper _alWrap;
        private readonly ILogger<AnimeController> _logger;

        public AnimeController(AniWrapper alWrap, ILogger<AnimeController> logger)
        {
            _alWrap = alWrap;
            _logger = logger;
        }

        [HttpGet("Test", Name = "GetTest")]
        [ProducesResponseType(typeof(AnimeDto), StatusCodes.Status200OK)]
        public async Task<Media> GetTest()
        {
            Media result = await _alWrap.GetAnime(108632);
            return result;
        }
    }
}
