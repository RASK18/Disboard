namespace AniList.ModelMaker.Introspection
{
    /// <summary>
    /// One possible value for a given Enum. Enum values are unique values, not a placeholder for a string or numeric value.
    /// However an Enum value is returned in a JSON response as a string.
    /// </summary>
    public class EnumValueQl
    {
        public bool IsDeprecated { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DeprecationReason { get; set; }
    }
}
