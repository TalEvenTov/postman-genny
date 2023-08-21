using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostmanGenny.Models.v20
{
    public class Collection
    {
        [JsonProperty(PropertyName = "info")]
        public Information Information { get; set; }
    }
}
