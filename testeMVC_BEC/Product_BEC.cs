using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace testeMVC_BEC
{
    [DataContract]
    public class Product_BEC
    {
        [IgnoreDataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonIgnore]
        public int Sku
        { get; set; }


        public string Name
        { get; set; }


        public bool isMarketable
        { get; set; }

        [IgnoreDataMember]
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        [JsonIgnore]
        public inventory_BEC inventory
        { get; set; }
}
}
