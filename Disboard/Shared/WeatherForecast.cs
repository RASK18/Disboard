using System;
using System.Collections.Generic;

namespace Disboard.Shared
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public string Summary { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public List<Episode> Episodes { get; set; } = new List<Episode>();

        public WeatherForecast()
        {
            Episodes.Add(new Episode(true, 5, 2, 2, "Prueba"));
        }
    }
}
