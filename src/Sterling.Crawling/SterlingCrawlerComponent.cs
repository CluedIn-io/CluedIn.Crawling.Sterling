using CluedIn.Core;
using CluedIn.Crawling.Sterling.Core;

using ComponentHost;

namespace CluedIn.Crawling.Sterling
{
    [Component(SterlingConstants.CrawlerComponentName, "Crawlers", ComponentType.Service, Components.Server, Components.ContentExtractors, Isolation = ComponentIsolation.NotIsolated)]
    public class SterlingCrawlerComponent : CrawlerComponentBase
    {
        public SterlingCrawlerComponent([NotNull] ComponentInfo componentInfo)
            : base(componentInfo)
        {
        }
    }
}

