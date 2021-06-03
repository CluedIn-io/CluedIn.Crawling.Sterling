using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace CluedIn.Crawling.Sterling.Core.Models
{
  
    public class Account
    {

        [JsonProperty("accountId")]
        public string AccountId { get; set; }

        [JsonProperty("accountName")]
        public string AccountName { get; set; }
    }


}
