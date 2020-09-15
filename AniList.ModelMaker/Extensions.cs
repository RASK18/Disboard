namespace AniList.ModelMaker
{
    public static class Extensions
    {
        public static string AlignLeft(this string str, int pad) => str.PadLeft(str.Length + pad);
        public static string CamelToPascal(this string str) => char.ToUpperInvariant(str[0]) + str.Substring(1);
    }
}
