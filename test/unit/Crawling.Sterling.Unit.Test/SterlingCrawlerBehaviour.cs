using CluedIn.Core.Crawling;
using CluedIn.Crawling;
using CluedIn.Crawling.Sterling;
using CluedIn.Crawling.Sterling.Infrastructure.Factories;
using Moq;
using Shouldly;
using Xunit;

namespace Crawling.Sterling.Unit.Test
{
    public class SterlingCrawlerBehaviour
    {
        private readonly ICrawlerDataGenerator _sut;

        public SterlingCrawlerBehaviour()
        {
            var nameClientFactory = new Mock<ISterlingClientFactory>();

            _sut = new SterlingCrawler(nameClientFactory.Object);
        }

        [Fact]
        public void GetDataReturnsData()
        {
            var jobData = new CrawlJobData();

            _sut.GetData(jobData)
                .ShouldNotBeNull();
        }
    }
}
