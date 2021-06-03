using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Sterling.Core.Models
{
    public class BillCode
    {

        [JsonProperty("billCodes")]
        public List<string> BillCodes { get; set; }
    }
}
