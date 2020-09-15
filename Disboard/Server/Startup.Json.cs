using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Disboard.Server
{
    public partial class Startup
    {
        private static void ConfigureJsonSettings()
        {
            DefaultContractResolver camelCase = new DefaultContractResolver { NamingStrategy = new CamelCaseNamingStrategy() };

            // Json Settings for all static Serialize and Deserialize
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                ContractResolver = camelCase,
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };
        }
    }
}