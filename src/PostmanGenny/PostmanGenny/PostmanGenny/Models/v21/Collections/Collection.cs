using Newtonsoft.Json;

namespace PostmanGenny.Models.v21.Collections
{
    public class Collection : v20.Collections.Collection
    {
        [JsonProperty(PropertyName = "info")]
        public new Information Information { get; set; }

        #region Constructors

        public Collection()
        {
            Information = new Information();
        }

        #endregion
    }
}
