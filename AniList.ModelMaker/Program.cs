using AniList.ModelMaker.Introspection;
using AniList.ModelMaker.Introspection.Enums;
using GraphQL.Query.Builder;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AniList.ModelMaker
{
    internal class Program
    {
        private static readonly string AniListPath =
            Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
                .Parent?.Parent?.Parent?.Parent?.FullName + "\\Disboard\\Server\\AniList";

        private static async Task Main()
        {
            InitialConfigs();
            string query = BuildQuery();
            string content = await PostQuery(query);
            SchemaQl schema = MapResponse(content);
            List<TypeQl> types = FilterTypes(schema);

            List<TypeQl> enums = types.Where(t => t.Kind == TypeKindQl.Enum).ToList();
            foreach (TypeQl type in enums)
            {
                WriteEnum(type);
            }

            List<TypeQl> objects = types.Where(t => t.Kind == TypeKindQl.Object).ToList();
            foreach (TypeQl type in objects)
            {
                WriteObject(type);
            }
        }

        private static void InitialConfigs()
        {
            // Json Settings for all static Serialize and Deserialize
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() },
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };
        }

        private static string BuildQuery()
        {
            QueryOptions opt = new QueryOptions { Formatter = QueryFormatters.CamelCaseFormatter };

            IQuery<SchemaQl> iQuery = new Query<SchemaQl>("__schema", opt)
                .AddField(ss => ss.Types,
                    st => st
                        .AddField(t => t.Kind)
                        .AddField(t => t.Name)
                        .AddField(t => t.Description)
                        .AddField(t => t.Fields,
                            tf => tf
                                .AddField(f => f.Name)
                                .AddField(f => f.Description)
                                .AddField(f => f.Type,
                                    ft => ft
                                        .AddField(t => t.Kind)
                                        .AddField(t => t.Name)))
                        .AddField(t => t.EnumValues,
                            tev => tev
                                .AddField(ev => ev.Name)
                                .AddField(ev => ev.Description)));

            string query = $"{{ {iQuery.Build()} }}";
            return query;
        }

        private static async Task<string> PostQuery(string query, string opName = null, object vars = null)
        {
            AniRequest request = new AniRequest(query, opName, vars);
            string json = JsonConvert.SerializeObject(request);
            HttpContent contentRequest = new StringContent(json, Encoding.UTF8, "application/json");

            using HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.PostAsync("https://graphql.anilist.co", contentRequest);

            string content = await response.Content.ReadAsStringAsync();
            return content;
        }

        private static SchemaQl MapResponse(string content)
        {
            JObject jObject = JObject.Parse(content);
            JToken errors = jObject["errors"];

            if (errors != null)
            {
                List<AniError> aniErrors = errors.ToObject<IEnumerable<AniError>>()?.ToList();

                if (aniErrors == null || !aniErrors.Any())
                    throw new Exception($"Errors found but couldn't be mapped: \r\n{content}");

                string exText = aniErrors.Aggregate("", (current, aniError) => current + $"{aniError.Status} - {aniError.Message}\r\n");
                throw new Exception(exText);
            }

            JToken data = jObject["data"];
            JToken item = data?["__schema"];
            SchemaQl schema = item?.ToObject<SchemaQl>();
            return schema;
        }

        private static List<TypeQl> FilterTypes(SchemaQl schema)
        {
            List<TypeQl> types = schema.Types.Where(t => t.Kind == TypeKindQl.Enum ||
                                                         t.Kind == TypeKindQl.Object).ToList();

            return types;
        }

        private static void WriteEnum(TypeQl type)
        {
            string toWrite = "";
            List<EnumValueQl> enumValues = type.EnumValues.OrderBy(ev => ev.Name).ToList();

            toWrite += "using System.Runtime.Serialization;\r\n\r\n";
            toWrite += "namespace Disboard.Server.AniList.Enums\r\n";
            toWrite += "{\r\n";

            toWrite += "/// <summary>\r\n".AlignLeft(4);
            toWrite += $"/// {type.Description}\r\n".AlignLeft(4);
            toWrite += "/// </summary>\r\n".AlignLeft(4);
            toWrite += $"public enum {type.Name}\r\n".AlignLeft(4);
            toWrite += "{\r\n".AlignLeft(4);

            foreach (EnumValueQl enumValue in enumValues)
            {
                toWrite += "/// <summary>\r\n".AlignLeft(8);
                toWrite += $"/// {enumValue.Description}\r\n".AlignLeft(8);
                toWrite += "/// </summary>\r\n".AlignLeft(8);
                toWrite += $"[EnumMember(Value = \"{enumValue.Name}\")] {ConvertEnumName(enumValue.Name)},\r\n".AlignLeft(8);
            }

            toWrite += "}\r\n".AlignLeft(4);
            toWrite += "}\r\n";

            File.WriteAllText($"{AniListPath}\\Enums\\{type.Name}.cs", toWrite);
        }

        private static string ConvertEnumName(string name)
        {
            string titleCase = name.Split('_')
                                   .Select(w => char.ToUpperInvariant(w[0]) + w.Substring(1).ToLowerInvariant())
                                   .Aggregate((i, j) => i + j);

            return titleCase;
        }

        private static void WriteObject(TypeQl type)
        {
            string toWrite = "";
            List<FieldQl> fields = type.Fields.OrderBy(f => f.Type.Kind).ThenBy(f => f.Type.Name).ToList();

            if (fields.Any(f => f.Type.Kind == TypeKindQl.Enum))
            {
                toWrite += "using Disboard.Server.AniList.Enums;\r\n";
            }

            if (fields.Any(f => f.Type.Kind == TypeKindQl.List))
            {
                toWrite += "using System.Collections.Generic;\r\n";
            }

            if (toWrite != "")
                toWrite += "\r\n";

            toWrite += "namespace Disboard.Server.AniList.Models\r\n";
            toWrite += "{\r\n";

            toWrite += "/// <summary>\r\n".AlignLeft(4);
            toWrite += $"/// {type.Description}\r\n".AlignLeft(4);
            toWrite += "/// </summary>\r\n".AlignLeft(4);
            toWrite += $"public class {type.Name}\r\n".AlignLeft(4);
            toWrite += "{\r\n".AlignLeft(4);

            foreach (FieldQl field in fields)
            {
                toWrite += "/// <summary>\r\n".AlignLeft(8);
                toWrite += $"/// {field.Description}\r\n".AlignLeft(8);
                toWrite += "/// </summary>\r\n".AlignLeft(8);
                toWrite += $"public {ConvertType(field.Type)} {field.Name} {{ get; set; }}\r\n".AlignLeft(8);
            }

            toWrite += "}\r\n".AlignLeft(4);
            toWrite += "}\r\n";

            File.WriteAllText($"{AniListPath}\\Models\\{type.Name}.cs", toWrite);
        }

        private static string ConvertType(TypeQl type)
        {

            return type.Name;
        }

    }
}
