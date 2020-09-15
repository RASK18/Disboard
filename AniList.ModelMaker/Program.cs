using AniList.ModelMaker.Introspection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AniList.ModelMaker
{
    internal class Program
    {
        private const string UsingClass1 = "using Disboard.Server.AniList.Enums;";
        private const string UsingClass2 = "using System.Collections.Generic;";
        private const string UsingEnum1 = "using System.Runtime.Serialization;";
        private const string NamespaceTmp = "namespace Disboard.Server.AniList.{0}";
        private const string SummaryStart = "/// <summary>";
        private const string SummaryTmp = "/// {0}";
        private const string SummaryEnd = "/// </summary>";
        private const string ObjectTmp = "public {0} {1}";
        private const string EnumItemTmp = "[EnumMember(Value = \"{0}\")] {1},";
        private const string ClassItemTmp = "public {0} {1} { get; set; }";

        private static readonly string AniListPath = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory)
                                                         .Parent?.Parent?.Parent?.Parent?.FullName +
                                                     "\\Disboard\\Server\\AniList";

        private static async Task Main()
        {
            const string query = "{ __schema { types { kind name description fields { name description } enumValues { name description } } } }";

            using HttpClient client = new HttpClient();
            string json = JsonConvert.SerializeObject(new { query });
            HttpContent contentRequest = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await client.PostAsync("https://graphql.anilist.co", contentRequest);
            string content = await response.Content.ReadAsStringAsync();

            JObject jObject = JObject.Parse(content);
            JToken data = jObject["data"];
            JToken item = data?["__schema"];

            SchemaQl schema = item?.ToObject<SchemaQl>();


        }

    }
}
