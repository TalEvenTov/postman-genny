using Newtonsoft.Json;

namespace PostmanGenny.Models.v20.Collections.Authentication
{
    public class BearerTokenAuthDetails : AuthDetails
    {
        internal override string Type => "bearer";

        [JsonProperty(PropertyName = "token")]
        public string Token { get; set; }
    }
}
