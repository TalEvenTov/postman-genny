using Newtonsoft.Json;

namespace PostmanGenny.Models.v20
{
    public class Information
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "schema")]
        public virtual string Schema => PostmanSchemas.V20;
    }
}
