using Newtonsoft.Json;

namespace PostmanGenny.Models.v21.Collections
{
    public class Information : v20.Collections.Information
    {
        [JsonProperty(PropertyName = "schema")]
        public override string Schema => PostmanSchemas.V21;
    }
}
