using Newtonsoft.Json;

namespace PostmanGenny.Models.v21
{
    public class Information : v20.Information
    {
        [JsonProperty(PropertyName = "schema")]
        public override string Schema => PostmanSchemas.V21;
    }
}
