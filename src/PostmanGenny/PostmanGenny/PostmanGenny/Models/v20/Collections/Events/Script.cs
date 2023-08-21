using Newtonsoft.Json;

namespace PostmanGenny.Models.v20.Collections.Events
{
    public class Script
    {
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        [JsonProperty(PropertyName = "exec")]
        public string ExecutionBody { get; set; }
    }
}
