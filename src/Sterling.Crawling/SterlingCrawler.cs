using System.Collections.Generic;

using CluedIn.Core.Crawling;
using CluedIn.Crawling.Sterling.Core;
using CluedIn.Crawling.Sterling.Infrastructure.Factories;

namespace CluedIn.Crawling.Sterling
{
    public class SterlingCrawler : ICrawlerDataGenerator
    {
        private readonly ISterlingClientFactory clientFactory;
        public SterlingCrawler(ISterlingClientFactory clientFactory)
        {
            this.clientFactory = clientFactory;
        }

        public IEnumerable<object> GetData(CrawlJobData jobData)
        {
            if (!(jobData is SterlingCrawlJobData sterlingcrawlJobData))
            {
                yield break;
            }

            var client = clientFactory.CreateNew(sterlingcrawlJobData);

            //retrieve data from provider and yield objects
            
        }       
    }
}
