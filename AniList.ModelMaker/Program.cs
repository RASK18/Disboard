using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AniList.ModelMaker
{
    internal class Program
    {
        public static readonly string TxtPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
            .Parent?.Parent?.Parent?.FullName + "\\Definition.txt";

        public static readonly string AniListPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
                                                       .Parent?.Parent?.Parent?.Parent?.FullName +
                                                   "\\Disboard\\Server\\AniList";

        private static void Main()
        {
            string text = File.ReadAllText(TxtPath);
            List<string> splits = text.Split("\r\n\r\n").ToList();

            if (splits[0].Contains("..."))
                WriteClass(splits);
            else
                WriteEnum(splits);
        }

        private static void WriteEnum(IList<string> splits)
        {
            Console.Write("Name of enum: ");
            string enumName = Console.ReadLine();
            string enumSummary = splits[0];

            splits.RemoveAt(0);

            Dictionary<string, string> opts = splits
                .Select(s => s.Split("\r\n"))
                .ToDictionary(e => e[0], e => e[1]);

            string toWrite =
                 "using System.ComponentModel;\r\n" +
                 "\r\n" +
                 "namespace Disboard.Server.AniList.Enums\r\n" +
                 "{\r\n" +
                 "    /// <summary>\r\n" +
                $"    /// {enumSummary}\r\n" +
                 "    /// </summary>\r\n" +
                $"    public enum {enumName}\r\n" +
                 "    {\r\n";

            foreach ((string key, string value) in opts)
            {
                string titleCase = key.Split('_')
                                      .Select(w => char.ToUpperInvariant(w[0]) + w.Substring(1).ToLowerInvariant())
                                      .Aggregate((i, j) => i + j);

                toWrite +=
                     "        /// <summary>\r\n" +
                    $"        /// {value}\r\n" +
                     "        /// </summary>\r\n" +
                    $"        [Description(\"{key}\")] {titleCase},\r\n";
            }

            toWrite += "    }\r\n" +
                       "}\r\n";

            File.WriteAllText($"{AniListPath}\\Enums\\{enumName}.cs", toWrite);
        }

        private static void WriteClass(IList<string> splits)
        {
            int nameStart = splits[0].IndexOf(" ", StringComparison.Ordinal) + 1;
            int nameEnd = splits[0].IndexOf("...", StringComparison.Ordinal);
            int nameLength = nameEnd - nameStart;
            string className = splits[0].Substring(nameStart, nameLength);
            string classSummary = splits[0].Substring(nameEnd + 5);

            splits.RemoveAt(0);

            List<Property> props = new List<Property>();
            foreach (string split in splits)
            {
                string name = split.Remove(split.IndexOfAny(new[] { ':', '(' }));
                name = char.ToUpperInvariant(name[0]) + name.Substring(1);

                #region Type

                int typeStart = split.LastIndexOf(':') + 2;
                int typeEnd = split.IndexOf("\r\n", typeStart, StringComparison.Ordinal);
                int typeLength = typeEnd - typeStart;
                string type = split.Substring(typeStart, typeLength);

                if (type.StartsWith('['))
                {
                    string aux = type.Substring(1, typeLength - 2);

                    if (aux.Contains('!'))
                        aux = aux.Remove(aux.Length - 1);
                    else
                        aux += "?";

                    type = $"IEnumerable<{aux}>";
                }

                if (type.Contains('!'))
                    type = type.Remove(type.Length - 1);
                else
                    type += "?";

                type = type.Replace("Int?", "int?")
                           .Replace("String?", "string");

                #endregion

                string summary = split.Substring(typeEnd + 2);

                props.Add(new Property(name, type, summary));
            }

            string toWrite =
                 "using System;\r\n" +
                 "\r\n" +
                 "namespace Disboard.Server.AniList.Models\r\n" +
                 "{\r\n" +
                 "    /// <summary>\r\n" +
                $"    /// {classSummary}\r\n" +
                 "    /// </summary>\r\n" +
                $"    public class {className}\r\n" +
                 "    {\r\n";

            foreach (Property prop in props)
            {
                toWrite +=
                     "        /// <summary>\r\n" +
                    $"        /// {prop.Summary}\r\n" +
                     "        /// </summary>\r\n" +
                    $"        public {prop.Type} {prop.Name} {{ get; set; }}\r\n";
            }

            toWrite += "    }\r\n" +
                       "}\r\n";

            File.WriteAllText($"{AniListPath}\\Models\\{className}.cs", toWrite);
        }

    }
}
