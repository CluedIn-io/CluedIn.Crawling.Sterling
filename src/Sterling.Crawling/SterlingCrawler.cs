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

            foreach (var package in client.GetPackages())
            {
                yield return package;
            }

            foreach (var candidateId in sterlingcrawlJobData.CandidateIds)
            {
                foreach (var candidate in client.GetCandidates(candidateId))
                {
                    yield return candidate;
                    foreach(var screeningId in candidate.ScreeningIds)
                    {
                        yield return client.GetScreenings(screeningId.ToString());
                        yield return client.GetScreeningReports(screeningId.ToString());
                    }
                }
            }

            foreach (var package in client.GetBillCodes())
            {
                yield return package;
            }

            foreach (var identifyVerificationId in sterlingcrawlJobData.IdentifyVerificationIds)
            {
                yield return client.GetIdentifyVerification(identifyVerificationId.ToString());
            }
        }
    }
}
