using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Disboard.Server.AniList
{
    public class AniClient
    {
        private readonly HttpClient _client;

        public AniClient(HttpClient client)
        {
            client.BaseAddress = new Uri("https://graphql.anilist.co");
            _client = client;
        }

        public async Task<T> Send<T>(object variables)
        {
            string query = CreateQuery<T>();
            string json = JsonConvert.SerializeObject(new { variables, query });
            HttpContent contentRequest = new StringContent(json, Encoding.UTF8, "application/json");

            HttpResponseMessage response = await _client.PostAsync("", contentRequest);
            string content = await response.Content.ReadAsStringAsync();

            JObject jObject = JObject.Parse(content);
            JToken data = jObject["data"];
            JToken item = data[typeof(T).Name];

            T result = item.ToObject<T>();
            return result;
        }

        public string CreateQuery<T>()
        {
            string query = $"query ($id: Int) {{ {typeof(T).Name} (id: $id, type: ANIME)";

            query += QueryFields(typeof(T));

            query += " }";
            return query;
        }

        private static string QueryFields(Type type)
        {
            string query = " {";
            PropertyInfo[] props = type.GetProperties();
            foreach (PropertyInfo prop in props)
            {
                string name = char.ToLowerInvariant(prop.Name[0]) + prop.Name.Substring(1);
                query += $" {name}";

                Type toCheck = prop.PropertyType.GenericTypeArguments.FirstOrDefault() ?? prop.PropertyType;

                if (!toCheck.IsClass || toCheck.Assembly.FullName != type.Assembly.FullName) continue;

                query += QueryFields(toCheck);
            }

            query += " }";
            return query;
        }

    }
}
