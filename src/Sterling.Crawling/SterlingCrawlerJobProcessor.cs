using CluedIn.Crawling.Sterling.Core;

namespace CluedIn.Crawling.Sterling
{
    public class SterlingCrawlerJobProcessor : GenericCrawlerTemplateJobProcessor<SterlingCrawlJobData>
    {
        public SterlingCrawlerJobProcessor(SterlingCrawlerComponent component) : base(component)
        {
        }
    }
}
