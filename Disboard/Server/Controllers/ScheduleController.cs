using Disboard.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Disboard.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class ScheduleController
    {
        private readonly ILogger<ScheduleController> logger;

        public ScheduleController(ILogger<ScheduleController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public Schedule Get()
        {
            const string parasiteUrl = "https://i.pinimg.com/originals/44/18/41/4418417d433d9924ba4afbd6c689a502.jpg";
            const string drStoneUrl = "https://www.tierragamer.com/wp-content/uploads/2019/10/Dr-Stone-Anime-Poster.jpg";
            const string noGameNoLifeUrl = "https://www.generacionfriki.es/wp-content/uploads/2017/04/No-Game-No-Life-Generacion-Friki-PORTADA.jpg";

            Episode noGameNoLife1 = new Episode(true, 1, 1, 1, noGameNoLifeUrl);
            Episode drStone1 = new Episode(true, 2, 2, 1, drStoneUrl);
            Episode parasite1 = new Episode(true, 3, 3, 1, parasiteUrl);
            Episode noGameNoLife2 = new Episode(false, 4, 1, 2, noGameNoLifeUrl);
            Episode drStone2 = new Episode(true, 5, 2, 2, drStoneUrl);
            Episode parasite2 = new Episode(false, 6, 3, 2, parasiteUrl);

            Schedule schedule = new Schedule();
            schedule.Week[4].Episodes.Add(noGameNoLife1);
            schedule.Week[4].Episodes.Add(drStone1);
            schedule.Week[4].Episodes.Add(parasite1);
            schedule.Week[5].Episodes.Add(noGameNoLife2);
            schedule.Week[5].Episodes.Add(drStone2);
            schedule.Week[5].Episodes.Add(parasite2);

            return schedule;
        }

    }
}
