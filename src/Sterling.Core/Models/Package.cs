using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Sterling.Core.Models
{
    public class Package
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("active")]
        public bool Active { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("components")]
        public List<string> Components { get; set; }

        [JsonProperty("requiredFields")]
        public List<string> RequiredFields { get; set; }
    }


}
