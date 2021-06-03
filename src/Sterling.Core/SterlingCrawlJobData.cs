using System.Collections.Generic;
using CluedIn.Core.Crawling;

namespace CluedIn.Crawling.Sterling.Core
{
    public class SterlingCrawlJobData : CrawlJobData
    {
        public SterlingCrawlJobData()
        {
        }

        public SterlingCrawlJobData(IDictionary<string, object> config)
        {
            ApiKey = config["ApiKey"].ToString();
        }

        public string ApiKey { get; set; }

        public List<string> CandidateIds { get; set; }

        public List<string> IdentifyVerificationIds { get; set; }
    }
}
