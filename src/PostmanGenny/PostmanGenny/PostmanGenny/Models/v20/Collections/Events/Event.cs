using Newtonsoft.Json;

namespace PostmanGenny.Models.v20.Collections.Events
{
    public abstract class Event
    {
        [JsonProperty(PropertyName = "listen")]
        public abstract string Listen { get; }

        [JsonProperty(PropertyName = "script")]
        public Script Script { get; }
    }
}
