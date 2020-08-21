namespace Disboard.Shared
{
    public class Episode
    {
        public bool HasBeenReleased { get; set; }
        public int Id { get; set; }
        public int AnimeId { get; set; }
        public int Number { get; set; }
        public string ImgUrl { get; set; }

        public Episode() { }
        public Episode(bool hasBeenReleased, int id, int animeId, int number, string imgUrl)
        {
            HasBeenReleased = hasBeenReleased;
            Id = id;
            AnimeId = animeId;
            Number = number;
            ImgUrl = imgUrl;
        }
    }
}
