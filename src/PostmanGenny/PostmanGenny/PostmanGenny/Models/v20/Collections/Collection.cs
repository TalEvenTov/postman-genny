using Newtonsoft.Json;
using PostmanGenny.Models.v20.Collections.Authentication;
using PostmanGenny.Models.v20.Collections.Events;

namespace PostmanGenny.Models.v20.Collections
{
    public class Collection
    {
        [JsonProperty(PropertyName = "info")]
        public Information Information { get; set; }

        [JsonProperty(PropertyName = "event")]
        public IEnumerable<Event> EventList { get; set; }

        [JsonProperty(PropertyName = "auth", NullValueHandling = NullValueHandling.Ignore)]
        public Auth Authentication { get; set; }

        #region Constructors

        public Collection()
        {
            Information = new Information();
            EventList = new List<Event>();
        }

        #endregion
    }
}
