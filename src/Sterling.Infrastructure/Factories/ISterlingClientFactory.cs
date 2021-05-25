using CluedIn.Crawling.Sterling.Core;

namespace CluedIn.Crawling.Sterling.Infrastructure.Factories
{
    public interface ISterlingClientFactory
    {
        SterlingClient CreateNew(SterlingCrawlJobData sterlingCrawlJobData);
    }
}
