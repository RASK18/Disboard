using Disboard.Shared;
using JikanDotNet;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Disboard.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class AnimeController
    {
        private readonly IJikan _jikan;
        private readonly ILogger<ScheduleController> _logger;

        public AnimeController(IJikan jikan, ILogger<ScheduleController> logger)
        {
            _jikan = jikan;
            _logger = logger;
        }

        [HttpGet("Popular", Name = "GetPopularAnime")]
        [ProducesResponseType(typeof(Schedule), StatusCodes.Status200OK)]
        public async Task<IEnumerable<AnimeDto>> GetPopular()
        {
            AnimeTop animeTop = await _jikan.GetAnimeTop(TopAnimeExtension.TopTV);

            IEnumerable<AnimeDto> animesDto = animeTop.Top.Take(24).Select(a => new AnimeDto(a));
            return animesDto;
        }
    }
}
