using Newtonsoft.Json;

namespace PostmanGenny.Models.v20.Collections.Events
{
    public class TestScriptEvent : Event
    {
        [JsonProperty(PropertyName = "listen")]
        public override string Listen => "test";
    }
}
