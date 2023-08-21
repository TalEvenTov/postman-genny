using Newtonsoft.Json;

namespace PostmanGenny.Models.v20.Collections.Authentication
{ 
    [JsonConverter(typeof(AuthConverter))]
    public class Auth
    {
        [JsonProperty(PropertyName = "type")]
        public string Type => AuthDetails.Type;

        public AuthDetails AuthDetails { get; set; }
    }

    class AuthConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            // this converter can be applied to any type
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            // we currently support only writing of JSON
            throw new NotImplementedException();
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (value == null)
            {
                serializer.Serialize(writer, null);
                return;
            }

            Auth auth = value as Auth;

            writer.WriteStartObject();

            writer.WritePropertyName("type");
            writer.WriteValue(auth.Type);

            writer.WritePropertyName(auth.Type);
            serializer.Serialize(writer, auth.AuthDetails);
            
            writer.WriteEndObject();
        }
    }
}
