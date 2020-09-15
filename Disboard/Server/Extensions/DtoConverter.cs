using Disboard.Server.AniList.Models;
using Disboard.Shared;

namespace Disboard.Server.Extensions
{
    public static class DtoConverter
    {
        public static AnimeDto ToDto(this Media media) =>
            new AnimeDto
            {
                Id = media.Id,
                Name = media.Title?.Romaji
            };
    }
}
