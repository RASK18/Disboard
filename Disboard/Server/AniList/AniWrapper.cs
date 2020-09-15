using Disboard.Server.AniList.Models;
using System.Threading.Tasks;

namespace Disboard.Server.AniList
{
    public class AniWrapper
    {
        private readonly AniClient _aniClient;

        public AniWrapper(AniClient aniClient)
        {
            _aniClient = aniClient;
        }

        public async Task<Media> GetAnime(int id)
        {
            object variables = new { id };

            Media media = await _aniClient.Send<Media>(variables);
            return media;
        }

    }
}
