namespace AniList.ModelMaker
{
    public static class Extensions
    {
        public static string AlignLeft(this string str, int pad) => str.PadLeft(str.Length + pad);
    }
}
