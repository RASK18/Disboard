using JikanDotNet;

namespace Disboard.Shared
{
    public class GenreDto
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public GenreDto() { }
        public GenreDto(MALSubItem genre)
        {
            Id = genre.MalId;
            Name = genre.Name;
        }
    }
}
