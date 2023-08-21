using Newtonsoft.Json;

namespace PostmanGenny.Models.v20.Collections.Authentication
{
    public class BasicAuthDetails : AuthDetails
    {
        internal override string Type => "basic";

        [JsonProperty(PropertyName = "username")]
        public string Username { get; set; }

        [JsonProperty(PropertyName = "password")]
        public string Password { get; set; }
    }
}
