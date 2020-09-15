namespace AniList.ModelMaker
{
    internal class Property
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }

        public Property(string name, string type, string summary)
        {
            Name = name;
            Type = type;
            Summary = summary;
        }
    }
}
