using Disboard.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;

namespace Disboard.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ScheduleController
    {
        private readonly ILogger<ScheduleController> logger;

        public ScheduleController(ILogger<ScheduleController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public IEnumerable<Day> Get()
        {
            const string parasiteUrl = "https://i.pinimg.com/originals/44/18/41/4418417d433d9924ba4afbd6c689a502.jpg";
            const string drStoneUrl = "https://www.tierragamer.com/wp-content/uploads/2019/10/Dr-Stone-Anime-Poster.jpg";
            const string noGameNoLifeUrl = "https://www.generacionfriki.es/wp-content/uploads/2017/04/No-Game-No-Life-Generacion-Friki-PORTADA.jpg";

            DateTimeOffset now = DateTimeOffset.Now;

            Episode noGameNoLife1 = new Episode(true, 1, 1, 1, noGameNoLifeUrl);
            Episode drStone1 = new Episode(true, 2, 2, 1, drStoneUrl);
            Episode parasite1 = new Episode(true, 3, 3, 1, parasiteUrl);

            List<Episode> fridayList = new List<Episode> { noGameNoLife1, drStone1, parasite1 };
            Day friday = new Day(now.Date, fridayList);

            Episode noGameNoLife2 = new Episode(false, 4, 1, 2, noGameNoLifeUrl);
            Episode drStone2 = new Episode(true, 5, 2, 2, drStoneUrl);
            Episode parasite2 = new Episode(false, 6, 3, 2, parasiteUrl);

            List<Episode> saturdayList = new List<Episode> { noGameNoLife2, drStone2, parasite2 };
            Day saturday = new Day(now.AddDays(1).Date, saturdayList);

            return new List<Day> { friday, saturday };
        }

    }
}
